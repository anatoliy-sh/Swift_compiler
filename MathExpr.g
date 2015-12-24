grammar MathExpr;

options {
  language=CSharp2;
  output=AST;
  ASTLabelType = AstNode;

  backtrack=true;
  memoize=true;
}


tokens {
  UNKNOWN             ;
  PRINT   = 'print'   ;
  INPUT   = 'input'   ;
  BLOCK               ;
  PROGRAM             ;
  BEGIN = '{'         ;
  END = '}'           ;
  IF = 'if'			  ;
  ELSE = 'else'       ;
  WHILE = 'while'     ;
  FOR = 'for'         ;
  AND = '&&'          ;
  OR = '||'           ;
  NOT = '!'           ; 
  FUNC_PARAM          ;
  LET = 'let'         ;
  INT= 'Int'          ;
  REPEATE = 'repeate' ;
  STRING= 'String'    ;
  DOUBLE= 'Double'    ;
  FLOAT= 'Float'      ;
  BOOL = 'Boolean'    ;
  VAR='var'           ;
  IN = 'in'	;
  PARAMS ;
  FUNC_CALL;
  ARRAY;
  PROGRAM;
  FUNC = 'func';
  RETURN = 'return';
  SWITCH = 'switch';
  CASE = 'case';
  DEFAULT = 'default';
  TYPE;
  ARRAY;
  CASEPARAM;
  VARS;
  TRUE    = 'true'        ;
  FALSE   = 'false'       ;
  SINCR;
  EINCR;
  SDECR;
  EDECR;
  CONVERT;
  ARRAYPART;
}


@lexer::namespace { MathExpr }
@parser::namespace { MathExpr }


WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=HIDDEN;
  }
;

SL_COMMENT:
  '//' (options { greedy=false; }: .)* '\r'? '\n' {
    $channel=HIDDEN;
  }
;
ML_COMMENT:
  '/*' (options { greedy=false; }: .)* '*/' {
    $channel=HIDDEN;
  }
;



NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
STRINGVAL: ('"')  ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )* ('"');

//BOOLVALUE: ;

IDENT:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;


array: IDENT ('[' add ']')+ -> ^(ARRAYPART IDENT  (add)*);

idar: array | IDENT;

ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;
ASSIGN: '='    ;
INCR: '++';
DECR: '--';
ADDAS:    '+='     ;
SUBAS:    '-='     ;
MULAS:    '*='     ;
DIVAS:    '/='     ;


GE: '>=';
LE: '<=';
EQ: '==';
NE: '!=';
GT: '>';
LT: '<';



type: INT | STRING | DOUBLE | FLOAT | BOOL | ('[' type ']') -> ^(ARRAY type);

value: NUMBER | TRUE | FALSE  | STRINGVAL;

returnValue: term | value | IDENT;

arrayValue:('['! returnValue (','! returnValue)* ']'! ) | ('[' arrayValue (',' arrayValue)* ']' ) -> ^(ARRAY arrayValue)*;

crement: INCR idar -> ^(SINCR idar) | idar INCR -> ^(EINCR idar) | DECR idar -> ^(SDECR idar) | idar DECR -> ^(EDECR idar) ;

allassign: ASSIGN | ADDAS | SUBAS | MULAS | DIVAS;

swcase:  (CASE returnValue (',' returnValue)* ':' expr )  -> ^(CASE ^(CASEPARAM (returnValue)*) expr);

paramms:
returnValue (',' returnValue)* -> ^(PARAMS returnValue*)
;

func_params:
IDENT ':' type (',' IDENT ':' type)* -> ^(IDENT type)*
;

func_call:
IDENT '(' paramms? ')' -> ^(FUNC_CALL IDENT paramms?)
;

var_element: idar (':' type ('(count' ':' add ')') )?  (ASSIGN ( returnValue | arrayValue))? -> ^(idar ^(TYPE type add)? ^(ASSIGN returnValue? ^(ARRAY arrayValue)?)?)
;



group:
 groupExpr |  groupInit
;

groupInit:
  '('! term ')'!
| IDENT 
| value
| array
;

groupExpr:
	func_call
  | crement
;


not:
  NOT^ group
| group
;

mult: not ( ( MUL | DIV )^ not )*  ;
add:  mult  ( ( ADD | SUB )^ mult  )*  ;
term: or_logic  ;

compare: 
		add ((GE|LE|EQ|NE|LT|GT)^ add)?
;

and_logic: compare (AND^ compare)* ;
or_logic: and_logic (OR^ and_logic)* ;



expr:
  BEGIN exprList END -> ^(BLOCK exprList?)
| idar allassign^ term
| IF^ term expr (ELSE! expr)?
| WHILE^ term  expr
| FOR (VAR IDENT ASSIGN term )? ';' compare? ';' ( groupExpr)? expr -> ^(FOR ^(VAR ^(IDENT TYPE ^(ASSIGN term)))? compare? groupExpr? expr)
| LET idar (':' type)? (ASSIGN returnValue)? (',' idar (':' type)? (ASSIGN returnValue )?)* -> ^(LET ^(idar ^(TYPE type?) ^(ASSIGN returnValue)? )*)
| VAR var_element (',' var_element)* -> ^(VAR var_element*)
| FOR^ VAR!? IDENT IN! term '...'! term expr
| PRINT^ '('! ( STRINGVAL | idar  )')'!
| groupExpr
| REPEATE expr WHILE term -> ^(REPEATE term expr)
| FUNC IDENT '(' func_params? ')' ('->' type)? expr -> ^(FUNC IDENT ^( FUNC_PARAM func_params?) ^(TYPE type?) expr)
| RETURN (returnValue |  arrayValue) -> ^(RETURN returnValue? ^(ARRAY arrayValue)?)
| SWITCH IDENT '{' (swcase)* (DEFAULT ':' expr)? '}' -> ^(SWITCH IDENT  (swcase)* (DEFAULT expr)? )
;

exprList: (expr ((';'!)?  exprList | (';'!)*))?
;

program:  exprList 
;


public execute:
    program -> ^(PROGRAM program)
;
