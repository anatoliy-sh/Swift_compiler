// $ANTLR 3.2 Sep 23, 2009 12:02:23 MathExpr.g 2015-12-24 12:22:35

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  MathExpr 
{
public partial class MathExprLexer : Lexer {
    public const int PRINT = 5;
    public const int STRINGVAL = 51;
    public const int ADD = 53;
    public const int INPUT = 6;
    public const int ARRAY = 30;
    public const int DIVAS = 63;
    public const int VARS = 38;
    public const int VAR = 26;
    public const int LT = 69;
    public const int REPEATE = 21;
    public const int CONVERT = 45;
    public const int SINCR = 41;
    public const int ELSE = 12;
    public const int EDECR = 44;
    public const int ARRAYPART = 46;
    public const int IF = 11;
    public const int TYPE = 36;
    public const int SUB = 54;
    public const int NUMBER = 50;
    public const int IN = 27;
    public const int MUL = 55;
    public const int BLOCK = 7;
    public const int FOR = 14;
    public const int TRUE = 39;
    public const int EQ = 66;
    public const int CASE = 34;
    public const int DECR = 59;
    public const int NOT = 17;
    public const int SDECR = 43;
    public const int MULAS = 62;
    public const int FUNC_CALL = 29;
    public const int AND = 15;
    public const int NE = 67;
    public const int END = 10;
    public const int SWITCH = 33;
    public const int PARAMS = 28;
    public const int PROGRAM = 8;
    public const int ADDAS = 60;
    public const int T__70 = 70;
    public const int T__71 = 71;
    public const int FLOAT = 24;
    public const int CASEPARAM = 37;
    public const int T__72 = 72;
    public const int BEGIN = 9;
    public const int ASSIGN = 57;
    public const int INT = 20;
    public const int RETURN = 32;
    public const int T__77 = 77;
    public const int T__78 = 78;
    public const int T__79 = 79;
    public const int DOUBLE = 23;
    public const int T__73 = 73;
    public const int WS = 47;
    public const int EOF = -1;
    public const int T__74 = 74;
    public const int T__75 = 75;
    public const int GE = 64;
    public const int T__76 = 76;
    public const int OR = 16;
    public const int FUNC = 31;
    public const int SUBAS = 61;
    public const int GT = 68;
    public const int DIV = 56;
    public const int IDENT = 52;
    public const int BOOL = 25;
    public const int ML_COMMENT = 49;
    public const int INCR = 58;
    public const int EINCR = 42;
    public const int SL_COMMENT = 48;
    public const int STRING = 22;
    public const int LE = 65;
    public const int WHILE = 13;
    public const int LET = 19;
    public const int FALSE = 40;
    public const int UNKNOWN = 4;
    public const int DEFAULT = 35;
    public const int FUNC_PARAM = 18;

    // delegates
    // delegators

    public MathExprLexer() 
    {
		InitializeCyclicDFAs();
    }
    public MathExprLexer(ICharStream input)
		: this(input, null) {
    }
    public MathExprLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "MathExpr.g";} 
    }

    // $ANTLR start "PRINT"
    public void mPRINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PRINT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:9:7: ( 'print' )
            // MathExpr.g:9:9: 'print'
            {
            	Match("print"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PRINT"

    // $ANTLR start "INPUT"
    public void mINPUT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INPUT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:10:7: ( 'input' )
            // MathExpr.g:10:9: 'input'
            {
            	Match("input"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INPUT"

    // $ANTLR start "BEGIN"
    public void mBEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:11:7: ( '{' )
            // MathExpr.g:11:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BEGIN"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:12:5: ( '}' )
            // MathExpr.g:12:7: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:13:4: ( 'if' )
            // MathExpr.g:13:6: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:14:6: ( 'else' )
            // MathExpr.g:14:8: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:15:7: ( 'while' )
            // MathExpr.g:15:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:16:5: ( 'for' )
            // MathExpr.g:16:7: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:17:5: ( '&&' )
            // MathExpr.g:17:7: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:18:4: ( '||' )
            // MathExpr.g:18:6: '||'
            {
            	Match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "NOT"
    public void mNOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:19:5: ( '!' )
            // MathExpr.g:19:7: '!'
            {
            	Match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOT"

    // $ANTLR start "LET"
    public void mLET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:20:5: ( 'let' )
            // MathExpr.g:20:7: 'let'
            {
            	Match("let"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LET"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:21:5: ( 'Int' )
            // MathExpr.g:21:7: 'Int'
            {
            	Match("Int"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "REPEATE"
    public void mREPEATE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REPEATE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:22:9: ( 'repeate' )
            // MathExpr.g:22:11: 'repeate'
            {
            	Match("repeate"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REPEATE"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:23:8: ( 'String' )
            // MathExpr.g:23:10: 'String'
            {
            	Match("String"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "DOUBLE"
    public void mDOUBLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:24:8: ( 'Double' )
            // MathExpr.g:24:10: 'Double'
            {
            	Match("Double"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOUBLE"

    // $ANTLR start "FLOAT"
    public void mFLOAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FLOAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:25:7: ( 'Float' )
            // MathExpr.g:25:9: 'Float'
            {
            	Match("Float"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FLOAT"

    // $ANTLR start "BOOL"
    public void mBOOL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BOOL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:26:6: ( 'Boolean' )
            // MathExpr.g:26:8: 'Boolean'
            {
            	Match("Boolean"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BOOL"

    // $ANTLR start "VAR"
    public void mVAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:27:5: ( 'var' )
            // MathExpr.g:27:7: 'var'
            {
            	Match("var"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VAR"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:28:4: ( 'in' )
            // MathExpr.g:28:6: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "FUNC"
    public void mFUNC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FUNC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:29:6: ( 'func' )
            // MathExpr.g:29:8: 'func'
            {
            	Match("func"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FUNC"

    // $ANTLR start "RETURN"
    public void mRETURN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RETURN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:30:8: ( 'return' )
            // MathExpr.g:30:10: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RETURN"

    // $ANTLR start "SWITCH"
    public void mSWITCH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SWITCH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:31:8: ( 'switch' )
            // MathExpr.g:31:10: 'switch'
            {
            	Match("switch"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SWITCH"

    // $ANTLR start "CASE"
    public void mCASE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CASE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:32:6: ( 'case' )
            // MathExpr.g:32:8: 'case'
            {
            	Match("case"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CASE"

    // $ANTLR start "DEFAULT"
    public void mDEFAULT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DEFAULT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:33:9: ( 'default' )
            // MathExpr.g:33:11: 'default'
            {
            	Match("default"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DEFAULT"

    // $ANTLR start "TRUE"
    public void mTRUE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRUE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:34:6: ( 'true' )
            // MathExpr.g:34:8: 'true'
            {
            	Match("true"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRUE"

    // $ANTLR start "FALSE"
    public void mFALSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FALSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:35:7: ( 'false' )
            // MathExpr.g:35:9: 'false'
            {
            	Match("false"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FALSE"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:36:7: ( '[' )
            // MathExpr.g:36:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:37:7: ( ']' )
            // MathExpr.g:37:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:38:7: ( ',' )
            // MathExpr.g:38:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:39:7: ( ':' )
            // MathExpr.g:39:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:40:7: ( '(' )
            // MathExpr.g:40:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:41:7: ( ')' )
            // MathExpr.g:41:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:42:7: ( '(count' )
            // MathExpr.g:42:9: '(count'
            {
            	Match("(count"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:43:7: ( ';' )
            // MathExpr.g:43:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:44:7: ( '...' )
            // MathExpr.g:44:9: '...'
            {
            	Match("..."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:45:7: ( '->' )
            // MathExpr.g:45:9: '->'
            {
            	Match("->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:66:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
            // MathExpr.g:67:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            {
            	// MathExpr.g:67:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '\t' && LA1_0 <= '\n') || (LA1_0 >= '\f' && LA1_0 <= '\r') || LA1_0 == ' ') )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // MathExpr.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            	    _channel=HIDDEN;
            	  

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "SL_COMMENT"
    public void mSL_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SL_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:72:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
            // MathExpr.g:73:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
            {
            	Match("//"); 

            	// MathExpr.g:73:8: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == '\r') )
            	    {
            	        alt2 = 2;
            	    }
            	    else if ( (LA2_0 == '\n') )
            	    {
            	        alt2 = 2;
            	    }
            	    else if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\t') || (LA2_0 >= '\u000B' && LA2_0 <= '\f') || (LA2_0 >= '\u000E' && LA2_0 <= '\uFFFF')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // MathExpr.g:73:36: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	// MathExpr.g:73:40: ( '\\r' )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == '\r') )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // MathExpr.g:73:40: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 

            	    _channel=HIDDEN;
            	  

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SL_COMMENT"

    // $ANTLR start "ML_COMMENT"
    public void mML_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ML_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:77:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // MathExpr.g:78:3: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); 

            	// MathExpr.g:78:8: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == '*') )
            	    {
            	        int LA4_1 = input.LA(2);

            	        if ( (LA4_1 == '/') )
            	        {
            	            alt4 = 2;
            	        }
            	        else if ( ((LA4_1 >= '\u0000' && LA4_1 <= '.') || (LA4_1 >= '0' && LA4_1 <= '\uFFFF')) )
            	        {
            	            alt4 = 1;
            	        }


            	    }
            	    else if ( ((LA4_0 >= '\u0000' && LA4_0 <= ')') || (LA4_0 >= '+' && LA4_0 <= '\uFFFF')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // MathExpr.g:78:36: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	Match("*/"); 


            	    _channel=HIDDEN;
            	  

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ML_COMMENT"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:85:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
            // MathExpr.g:85:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
            {
            	// MathExpr.g:85:9: ( '0' .. '9' )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // MathExpr.g:85:10: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee5 =
            		                new EarlyExitException(5, input);
            		            throw eee5;
            	    }
            	    cnt5++;
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	// MathExpr.g:85:21: ( '.' ( '0' .. '9' )+ )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == '.') )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // MathExpr.g:85:22: '.' ( '0' .. '9' )+
            	        {
            	        	Match('.'); 
            	        	// MathExpr.g:85:26: ( '0' .. '9' )+
            	        	int cnt6 = 0;
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            	        	    {
            	        	        alt6 = 1;
            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:85:27: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt6 >= 1 ) goto loop6;
            	        		            EarlyExitException eee6 =
            	        		                new EarlyExitException(6, input);
            	        		            throw eee6;
            	        	    }
            	        	    cnt6++;
            	        	} while (true);

            	        	loop6:
            	        		;	// Stops C# compiler whining that label 'loop6' has no statements


            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "STRINGVAL"
    public void mSTRINGVAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRINGVAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:87:10: ( ( '\"' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* ( '\"' ) )
            // MathExpr.g:87:12: ( '\"' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* ( '\"' )
            {
            	// MathExpr.g:87:12: ( '\"' )
            	// MathExpr.g:87:13: '\"'
            	{
            		Match('\"'); 

            	}

            	// MathExpr.g:87:19: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= '0' && LA8_0 <= '9') || (LA8_0 >= 'A' && LA8_0 <= 'Z') || LA8_0 == '_' || (LA8_0 >= 'a' && LA8_0 <= 'z')) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // MathExpr.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	// MathExpr.g:87:61: ( '\"' )
            	// MathExpr.g:87:62: '\"'
            	{
            		Match('\"'); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRINGVAL"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:91:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
            // MathExpr.g:91:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// MathExpr.g:92:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= '0' && LA9_0 <= '9') || (LA9_0 >= 'A' && LA9_0 <= 'Z') || LA9_0 == '_' || (LA9_0 >= 'a' && LA9_0 <= 'z')) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // MathExpr.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "ADD"
    public void mADD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ADD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:100:4: ( '+' )
            // MathExpr.g:100:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ADD"

    // $ANTLR start "SUB"
    public void mSUB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SUB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:101:4: ( '-' )
            // MathExpr.g:101:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SUB"

    // $ANTLR start "MUL"
    public void mMUL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MUL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:102:4: ( '*' )
            // MathExpr.g:102:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MUL"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:103:4: ( '/' )
            // MathExpr.g:103:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:104:7: ( '=' )
            // MathExpr.g:104:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    // $ANTLR start "INCR"
    public void mINCR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INCR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:105:5: ( '++' )
            // MathExpr.g:105:7: '++'
            {
            	Match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INCR"

    // $ANTLR start "DECR"
    public void mDECR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DECR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:106:5: ( '--' )
            // MathExpr.g:106:7: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DECR"

    // $ANTLR start "ADDAS"
    public void mADDAS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ADDAS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:107:6: ( '+=' )
            // MathExpr.g:107:11: '+='
            {
            	Match("+="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ADDAS"

    // $ANTLR start "SUBAS"
    public void mSUBAS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SUBAS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:108:6: ( '-=' )
            // MathExpr.g:108:11: '-='
            {
            	Match("-="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SUBAS"

    // $ANTLR start "MULAS"
    public void mMULAS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULAS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:109:6: ( '*=' )
            // MathExpr.g:109:11: '*='
            {
            	Match("*="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULAS"

    // $ANTLR start "DIVAS"
    public void mDIVAS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIVAS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:110:6: ( '/=' )
            // MathExpr.g:110:11: '/='
            {
            	Match("/="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIVAS"

    // $ANTLR start "GE"
    public void mGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:113:3: ( '>=' )
            // MathExpr.g:113:5: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GE"

    // $ANTLR start "LE"
    public void mLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:114:3: ( '<=' )
            // MathExpr.g:114:5: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LE"

    // $ANTLR start "EQ"
    public void mEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:115:3: ( '==' )
            // MathExpr.g:115:5: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQ"

    // $ANTLR start "NE"
    public void mNE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:116:3: ( '!=' )
            // MathExpr.g:116:5: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NE"

    // $ANTLR start "GT"
    public void mGT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:117:3: ( '>' )
            // MathExpr.g:117:5: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GT"

    // $ANTLR start "LT"
    public void mLT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:118:3: ( '<' )
            // MathExpr.g:118:5: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LT"

    override public void mTokens() // throws RecognitionException 
    {
        // MathExpr.g:1:8: ( PRINT | INPUT | BEGIN | END | IF | ELSE | WHILE | FOR | AND | OR | NOT | LET | INT | REPEATE | STRING | DOUBLE | FLOAT | BOOL | VAR | IN | FUNC | RETURN | SWITCH | CASE | DEFAULT | TRUE | FALSE | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | WS | SL_COMMENT | ML_COMMENT | NUMBER | STRINGVAL | IDENT | ADD | SUB | MUL | DIV | ASSIGN | INCR | DECR | ADDAS | SUBAS | MULAS | DIVAS | GE | LE | EQ | NE | GT | LT )
        int alt10 = 60;
        alt10 = dfa10.Predict(input);
        switch (alt10) 
        {
            case 1 :
                // MathExpr.g:1:10: PRINT
                {
                	mPRINT(); 

                }
                break;
            case 2 :
                // MathExpr.g:1:16: INPUT
                {
                	mINPUT(); 

                }
                break;
            case 3 :
                // MathExpr.g:1:22: BEGIN
                {
                	mBEGIN(); 

                }
                break;
            case 4 :
                // MathExpr.g:1:28: END
                {
                	mEND(); 

                }
                break;
            case 5 :
                // MathExpr.g:1:32: IF
                {
                	mIF(); 

                }
                break;
            case 6 :
                // MathExpr.g:1:35: ELSE
                {
                	mELSE(); 

                }
                break;
            case 7 :
                // MathExpr.g:1:40: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 8 :
                // MathExpr.g:1:46: FOR
                {
                	mFOR(); 

                }
                break;
            case 9 :
                // MathExpr.g:1:50: AND
                {
                	mAND(); 

                }
                break;
            case 10 :
                // MathExpr.g:1:54: OR
                {
                	mOR(); 

                }
                break;
            case 11 :
                // MathExpr.g:1:57: NOT
                {
                	mNOT(); 

                }
                break;
            case 12 :
                // MathExpr.g:1:61: LET
                {
                	mLET(); 

                }
                break;
            case 13 :
                // MathExpr.g:1:65: INT
                {
                	mINT(); 

                }
                break;
            case 14 :
                // MathExpr.g:1:69: REPEATE
                {
                	mREPEATE(); 

                }
                break;
            case 15 :
                // MathExpr.g:1:77: STRING
                {
                	mSTRING(); 

                }
                break;
            case 16 :
                // MathExpr.g:1:84: DOUBLE
                {
                	mDOUBLE(); 

                }
                break;
            case 17 :
                // MathExpr.g:1:91: FLOAT
                {
                	mFLOAT(); 

                }
                break;
            case 18 :
                // MathExpr.g:1:97: BOOL
                {
                	mBOOL(); 

                }
                break;
            case 19 :
                // MathExpr.g:1:102: VAR
                {
                	mVAR(); 

                }
                break;
            case 20 :
                // MathExpr.g:1:106: IN
                {
                	mIN(); 

                }
                break;
            case 21 :
                // MathExpr.g:1:109: FUNC
                {
                	mFUNC(); 

                }
                break;
            case 22 :
                // MathExpr.g:1:114: RETURN
                {
                	mRETURN(); 

                }
                break;
            case 23 :
                // MathExpr.g:1:121: SWITCH
                {
                	mSWITCH(); 

                }
                break;
            case 24 :
                // MathExpr.g:1:128: CASE
                {
                	mCASE(); 

                }
                break;
            case 25 :
                // MathExpr.g:1:133: DEFAULT
                {
                	mDEFAULT(); 

                }
                break;
            case 26 :
                // MathExpr.g:1:141: TRUE
                {
                	mTRUE(); 

                }
                break;
            case 27 :
                // MathExpr.g:1:146: FALSE
                {
                	mFALSE(); 

                }
                break;
            case 28 :
                // MathExpr.g:1:152: T__70
                {
                	mT__70(); 

                }
                break;
            case 29 :
                // MathExpr.g:1:158: T__71
                {
                	mT__71(); 

                }
                break;
            case 30 :
                // MathExpr.g:1:164: T__72
                {
                	mT__72(); 

                }
                break;
            case 31 :
                // MathExpr.g:1:170: T__73
                {
                	mT__73(); 

                }
                break;
            case 32 :
                // MathExpr.g:1:176: T__74
                {
                	mT__74(); 

                }
                break;
            case 33 :
                // MathExpr.g:1:182: T__75
                {
                	mT__75(); 

                }
                break;
            case 34 :
                // MathExpr.g:1:188: T__76
                {
                	mT__76(); 

                }
                break;
            case 35 :
                // MathExpr.g:1:194: T__77
                {
                	mT__77(); 

                }
                break;
            case 36 :
                // MathExpr.g:1:200: T__78
                {
                	mT__78(); 

                }
                break;
            case 37 :
                // MathExpr.g:1:206: T__79
                {
                	mT__79(); 

                }
                break;
            case 38 :
                // MathExpr.g:1:212: WS
                {
                	mWS(); 

                }
                break;
            case 39 :
                // MathExpr.g:1:215: SL_COMMENT
                {
                	mSL_COMMENT(); 

                }
                break;
            case 40 :
                // MathExpr.g:1:226: ML_COMMENT
                {
                	mML_COMMENT(); 

                }
                break;
            case 41 :
                // MathExpr.g:1:237: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 42 :
                // MathExpr.g:1:244: STRINGVAL
                {
                	mSTRINGVAL(); 

                }
                break;
            case 43 :
                // MathExpr.g:1:254: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 44 :
                // MathExpr.g:1:260: ADD
                {
                	mADD(); 

                }
                break;
            case 45 :
                // MathExpr.g:1:264: SUB
                {
                	mSUB(); 

                }
                break;
            case 46 :
                // MathExpr.g:1:268: MUL
                {
                	mMUL(); 

                }
                break;
            case 47 :
                // MathExpr.g:1:272: DIV
                {
                	mDIV(); 

                }
                break;
            case 48 :
                // MathExpr.g:1:276: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 49 :
                // MathExpr.g:1:283: INCR
                {
                	mINCR(); 

                }
                break;
            case 50 :
                // MathExpr.g:1:288: DECR
                {
                	mDECR(); 

                }
                break;
            case 51 :
                // MathExpr.g:1:293: ADDAS
                {
                	mADDAS(); 

                }
                break;
            case 52 :
                // MathExpr.g:1:299: SUBAS
                {
                	mSUBAS(); 

                }
                break;
            case 53 :
                // MathExpr.g:1:305: MULAS
                {
                	mMULAS(); 

                }
                break;
            case 54 :
                // MathExpr.g:1:311: DIVAS
                {
                	mDIVAS(); 

                }
                break;
            case 55 :
                // MathExpr.g:1:317: GE
                {
                	mGE(); 

                }
                break;
            case 56 :
                // MathExpr.g:1:320: LE
                {
                	mLE(); 

                }
                break;
            case 57 :
                // MathExpr.g:1:323: EQ
                {
                	mEQ(); 

                }
                break;
            case 58 :
                // MathExpr.g:1:326: NE
                {
                	mNE(); 

                }
                break;
            case 59 :
                // MathExpr.g:1:329: GT
                {
                	mGT(); 

                }
                break;
            case 60 :
                // MathExpr.g:1:332: LT
                {
                	mLT(); 

                }
                break;

        }

    }


    protected DFA10 dfa10;
	private void InitializeCyclicDFAs()
	{
	    this.dfa10 = new DFA10(this);
	}

    const string DFA10_eotS =
        "\x01\uffff\x02\x24\x02\uffff\x03\x24\x02\uffff\x01\x33\x0c\x24"+
        "\x04\uffff\x01\x41\x03\uffff\x01\x45\x01\uffff\x01\x49\x03\uffff"+
        "\x01\x4c\x01\x4e\x01\x50\x01\x52\x01\x54\x01\x24\x01\x57\x01\x58"+
        "\x05\x24\x02\uffff\x0c\x24\x15\uffff\x02\x24\x02\uffff\x02\x24\x01"+
        "\x6f\x02\x24\x01\x72\x01\x73\x06\x24\x01\x7a\x06\x24\x01\u0081\x01"+
        "\x24\x01\uffff\x01\u0083\x01\x24\x02\uffff\x06\x24\x01\uffff\x01"+
        "\x24\x01\u008c\x01\x24\x01\u008e\x01\u008f\x01\u0090\x01\uffff\x01"+
        "\u0091\x01\uffff\x01\u0092\x04\x24\x01\u0097\x02\x24\x01\uffff\x01"+
        "\x24\x05\uffff\x01\x24\x01\u009c\x01\u009d\x01\u009e\x01\uffff\x01"+
        "\x24\x01\u00a0\x01\x24\x01\u00a2\x03\uffff\x01\u00a3\x01\uffff\x01"+
        "\u00a4\x03\uffff";
    const string DFA10_eofS =
        "\u00a5\uffff";
    const string DFA10_minS =
        "\x01\x09\x01\x72\x01\x66\x02\uffff\x01\x6c\x01\x68\x01\x61\x02"+
        "\uffff\x01\x3d\x01\x65\x01\x6e\x01\x65\x01\x74\x01\x6f\x01\x6c\x01"+
        "\x6f\x01\x61\x01\x77\x01\x61\x01\x65\x01\x72\x04\uffff\x01\x63\x03"+
        "\uffff\x01\x2d\x01\uffff\x01\x2a\x03\uffff\x01\x2b\x04\x3d\x01\x69"+
        "\x02\x30\x01\x73\x01\x69\x01\x72\x01\x6e\x01\x6c\x02\uffff\x02\x74"+
        "\x01\x70\x01\x72\x01\x75\x02\x6f\x01\x72\x01\x69\x01\x73\x01\x66"+
        "\x01\x75\x15\uffff\x01\x6e\x01\x75\x02\uffff\x01\x65\x01\x6c\x01"+
        "\x30\x01\x63\x01\x73\x02\x30\x01\x65\x01\x75\x01\x69\x01\x62\x01"+
        "\x61\x01\x6c\x01\x30\x01\x74\x01\x65\x01\x61\x01\x65\x02\x74\x01"+
        "\x30\x01\x65\x01\uffff\x01\x30\x01\x65\x02\uffff\x01\x61\x01\x72"+
        "\x01\x6e\x01\x6c\x01\x74\x01\x65\x01\uffff\x01\x63\x01\x30\x01\x75"+
        "\x03\x30\x01\uffff\x01\x30\x01\uffff\x01\x30\x01\x74\x01\x6e\x01"+
        "\x67\x01\x65\x01\x30\x01\x61\x01\x68\x01\uffff\x01\x6c\x05\uffff"+
        "\x01\x65\x03\x30\x01\uffff\x01\x6e\x01\x30\x01\x74\x01\x30\x03\uffff"+
        "\x01\x30\x01\uffff\x01\x30\x03\uffff";
    const string DFA10_maxS =
        "\x01\x7d\x01\x72\x01\x6e\x02\uffff\x01\x6c\x01\x68\x01\x75\x02"+
        "\uffff\x01\x3d\x01\x65\x01\x6e\x01\x65\x01\x74\x01\x6f\x01\x6c\x01"+
        "\x6f\x01\x61\x01\x77\x01\x61\x01\x65\x01\x72\x04\uffff\x01\x63\x03"+
        "\uffff\x01\x3e\x01\uffff\x01\x3d\x03\uffff\x05\x3d\x01\x69\x02\x7a"+
        "\x01\x73\x01\x69\x01\x72\x01\x6e\x01\x6c\x02\uffff\x03\x74\x01\x72"+
        "\x01\x75\x02\x6f\x01\x72\x01\x69\x01\x73\x01\x66\x01\x75\x15\uffff"+
        "\x01\x6e\x01\x75\x02\uffff\x01\x65\x01\x6c\x01\x7a\x01\x63\x01\x73"+
        "\x02\x7a\x01\x65\x01\x75\x01\x69\x01\x62\x01\x61\x01\x6c\x01\x7a"+
        "\x01\x74\x01\x65\x01\x61\x01\x65\x02\x74\x01\x7a\x01\x65\x01\uffff"+
        "\x01\x7a\x01\x65\x02\uffff\x01\x61\x01\x72\x01\x6e\x01\x6c\x01\x74"+
        "\x01\x65\x01\uffff\x01\x63\x01\x7a\x01\x75\x03\x7a\x01\uffff\x01"+
        "\x7a\x01\uffff\x01\x7a\x01\x74\x01\x6e\x01\x67\x01\x65\x01\x7a\x01"+
        "\x61\x01\x68\x01\uffff\x01\x6c\x05\uffff\x01\x65\x03\x7a\x01\uffff"+
        "\x01\x6e\x01\x7a\x01\x74\x01\x7a\x03\uffff\x01\x7a\x01\uffff\x01"+
        "\x7a\x03\uffff";
    const string DFA10_acceptS =
        "\x03\uffff\x01\x03\x01\x04\x03\uffff\x01\x09\x01\x0a\x0d\uffff"+
        "\x01\x1c\x01\x1d\x01\x1e\x01\x1f\x01\uffff\x01\x21\x01\x23\x01\x24"+
        "\x01\uffff\x01\x26\x01\uffff\x01\x29\x01\x2a\x01\x2b\x0d\uffff\x01"+
        "\x3a\x01\x0b\x0c\uffff\x01\x22\x01\x20\x01\x25\x01\x32\x01\x34\x01"+
        "\x2d\x01\x27\x01\x28\x01\x36\x01\x2f\x01\x31\x01\x33\x01\x2c\x01"+
        "\x35\x01\x2e\x01\x39\x01\x30\x01\x37\x01\x3b\x01\x38\x01\x3c\x02"+
        "\uffff\x01\x14\x01\x05\x16\uffff\x01\x08\x02\uffff\x01\x0c\x01\x0d"+
        "\x06\uffff\x01\x13\x06\uffff\x01\x06\x01\uffff\x01\x15\x08\uffff"+
        "\x01\x18\x01\uffff\x01\x1a\x01\x01\x01\x02\x01\x07\x01\x1b\x04\uffff"+
        "\x01\x11\x04\uffff\x01\x16\x01\x0f\x01\x10\x01\uffff\x01\x17\x01"+
        "\uffff\x01\x0e\x01\x12\x01\x19";
    const string DFA10_specialS =
        "\u00a5\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x02\x20\x01\uffff\x02\x20\x12\uffff\x01\x20\x01\x0a\x01\x23"+
            "\x03\uffff\x01\x08\x01\uffff\x01\x1b\x01\x1c\x01\x26\x01\x25"+
            "\x01\x19\x01\x1f\x01\x1e\x01\x21\x0a\x22\x01\x1a\x01\x1d\x01"+
            "\x29\x01\x27\x01\x28\x02\uffff\x01\x24\x01\x11\x01\x24\x01\x0f"+
            "\x01\x24\x01\x10\x02\x24\x01\x0c\x09\x24\x01\x0e\x07\x24\x01"+
            "\x17\x01\uffff\x01\x18\x01\uffff\x01\x24\x01\uffff\x02\x24\x01"+
            "\x14\x01\x15\x01\x05\x01\x07\x02\x24\x01\x02\x02\x24\x01\x0b"+
            "\x03\x24\x01\x01\x01\x24\x01\x0d\x01\x13\x01\x16\x01\x24\x01"+
            "\x12\x01\x06\x03\x24\x01\x03\x01\x09\x01\x04",
            "\x01\x2a",
            "\x01\x2c\x07\uffff\x01\x2b",
            "",
            "",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x31\x0d\uffff\x01\x2f\x05\uffff\x01\x30",
            "",
            "",
            "\x01\x32",
            "\x01\x34",
            "\x01\x35",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38",
            "\x01\x39",
            "\x01\x3a",
            "\x01\x3b",
            "\x01\x3c",
            "\x01\x3d",
            "\x01\x3e",
            "\x01\x3f",
            "",
            "",
            "",
            "",
            "\x01\x40",
            "",
            "",
            "",
            "\x01\x43\x0f\uffff\x01\x44\x01\x42",
            "",
            "\x01\x47\x04\uffff\x01\x46\x0d\uffff\x01\x48",
            "",
            "",
            "",
            "\x01\x4a\x11\uffff\x01\x4b",
            "\x01\x4d",
            "\x01\x4f",
            "\x01\x51",
            "\x01\x53",
            "\x01\x55",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x0f"+
            "\x24\x01\x56\x0a\x24",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5d",
            "",
            "",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60\x03\uffff\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x6b",
            "\x01\x6c",
            "",
            "",
            "\x01\x6d",
            "\x01\x6e",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\x70",
            "\x01\x71",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\x7b",
            "\x01\x7c",
            "\x01\x7d",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u0082",
            "",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u0084",
            "",
            "",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "",
            "\x01\u008b",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u008d",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u0093",
            "\x01\u0094",
            "\x01\u0095",
            "\x01\u0096",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u0098",
            "\x01\u0099",
            "",
            "\x01\u009a",
            "",
            "",
            "",
            "",
            "",
            "\x01\u009b",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "\x01\u009f",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "\x01\u00a1",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "",
            "",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "\x0a\x24\x07\uffff\x1a\x24\x04\uffff\x01\x24\x01\uffff\x1a"+
            "\x24",
            "",
            "",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( PRINT | INPUT | BEGIN | END | IF | ELSE | WHILE | FOR | AND | OR | NOT | LET | INT | REPEATE | STRING | DOUBLE | FLOAT | BOOL | VAR | IN | FUNC | RETURN | SWITCH | CASE | DEFAULT | TRUE | FALSE | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | WS | SL_COMMENT | ML_COMMENT | NUMBER | STRINGVAL | IDENT | ADD | SUB | MUL | DIV | ASSIGN | INCR | DECR | ADDAS | SUBAS | MULAS | DIVAS | GE | LE | EQ | NE | GT | LT );"; }
        }

    }

 
    
}
}