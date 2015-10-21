grammar MathLang;

options {
  language=CSharp3;
  output=AST;
  backtrack=true;
}


tokens {
  UNKNOWN             ;
  PRINT   = 'print'   ;
  INPUT   = 'input'   ;
  BLOCK               ;
  PROGRAM = 'program' ;
  BEGIN = '{'     ;
  END = '}'         ;
  IF = 'if'			  ;
  ELSE = 'else'       ;
  WHILE = 'while'     ;
  FOR = 'for'         ;
  AND = '&&'         ;
  OR = '||'           ;
  NOT = '!'         ; 
  LET = 'let'         ;
  INT= 'Int';
  STRING= 'String';
  DOUBLE= 'Double';
  FLOAT= 'Float';
  VAR='var';
  IN = 'in';
  PARAMS ;
  FUNC_CALL;
  ARRAY;
}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }


WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;

SL_COMMENT:
  '//' (options { greedy=false; }: .)* '\r'? '\n' {
    $channel=Hidden;
  }
;
ML_COMMENT:
  '/*' (options { greedy=false; }: .)* '*/' {
    $channel=Hidden;
  }
;



NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
STRINGVAL: ('"')  ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )* ('"');

IDENT:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;

array: IDENT ('['! add ']'!)+ -> ^(ARRAY IDENT (add)*);

idar: IDENT| array;

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
EQ: '=';
NE: '!=';
GT: '>';
LT: '<';



type: INT | STRING | DOUBLE | FLOAT;

value: NUMBER |  STRINGVAL ;

crement: INCR^ idar | idar INCR^ | DECR^ idar | idar ^DECR ;

allassign: ASSIGN | ADDAS | SUBAS | MULAS | DIVAS;

paramms:
term (',' term)* -> ^(PARAMS term*)
;

func_call:
IDENT '(' paramms? ')' -> ^(FUNC_CALL IDENT paramms?)
;

group:
groupInit | groupExpr
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
| IDENT allassign^ term
| IF^ term expr (ELSE! expr)?
| WHILE^ term  expr
| FOR^ (VAR!? IDENT ASSIGN! term ';'!) compare ';'! ( groupExpr ';'!) expr
| LET^ IDENT (':'! type)? (ASSIGN! term)?
| VAR^ idar (':'! type)? (ASSIGN!term)?
| FOR^ VAR!? IDENT IN! term '...'! term expr
| PRINT '('! STRINGVAL ')'!
| groupExpr

;

exprList: expr ((';'!)?  exprList | (';'!)*)
;

program:  exprList 
;


public execute:
    program
;
