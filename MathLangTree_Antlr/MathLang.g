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
  DO = 'do'           ;
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

crement: INCR | DECR;

allassign: ASSIGN | ADDAS | SUBAS | MULAS | DIVAS;

group:
  '('! term ')'!
| (crement^)? IDENT (crement^)?
| value
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
//not_logic: (NOT^)* or_logic ;


expr:
  BEGIN exprList END -> ^(BLOCK exprList?)
| IDENT allassign^ term
| IF^ term expr /*(ELSE! IF! term expr)*/ (ELSE! expr)?
| WHILE^ term DO! expr
| //FOR^ (VAR! IDENT ASSIGN! term ';'!) compare ';'! (crement^ IDENT ';'!) expr
| LET^ IDENT (':'! type)? (ASSIGN! term)?
| VAR^ IDENT (':'! type)? (ASSIGN!term)?

;

exprList: expr ((';'!)+ exprList | (';'!)*)
;

program:  exprList 
;


public execute:
    program
;
