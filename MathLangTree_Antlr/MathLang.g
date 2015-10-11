grammar MathLang;

options {
  language=CSharp3;
  output=AST;
  //backtrack=true;
}


tokens {
  UNKNOWN             ;
  PRINT   = 'print'   ;
  INPUT   = 'input'   ;
  BLOCK               ;
  PROGRAM = 'program' ;
  BEGIN = 'begin'     ;
  END = 'end'         ;
  IF = 'if'			  ;
  THEN = 'then'       ;
  ELSE = 'else'       ;
  WHILE = 'while'     ;
  DO = 'do'           ;
  FOR = 'for'         ;
  TO = 'to'           ;
  DOWNTO = 'downto'   ;
  AND = 'and'         ;
  OR = 'or'           ;
  NOT = 'not'         ; 
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
IDENT:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;
ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;
ASSIGN: ':='    ;

GE: '>=';
LE: '<=';
EQ: '=';
NE: '<>';
GT: '>';
LT: '<';

group:
  '('! term ')'!
| NUMBER
| IDENT
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
| IDENT ASSIGN^ term
| IF^ term THEN! expr (ELSE! expr)?
| WHILE^ term DO! expr
| FOR^ IDENT ASSIGN! term (TO|DOWNTO) term DO! expr
;

exprList: expr ((';'!)+ exprList | (';'!)*)
;

program: BEGIN! exprList END!
;


public execute:
  PROGRAM! IDENT^ program
;
