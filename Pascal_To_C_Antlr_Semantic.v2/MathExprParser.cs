// $ANTLR 3.2 Sep 23, 2009 12:02:23 MathExpr.g 2015-11-04 20:44:47

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  MathExpr 
{
public partial class MathExprParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"UNKNOWN", 
		"PRINT", 
		"INPUT", 
		"BLOCK", 
		"PROGRAM", 
		"BEGIN", 
		"END", 
		"IF", 
		"ELSE", 
		"WHILE", 
		"FOR", 
		"AND", 
		"OR", 
		"NOT", 
		"FUNC_PARAM", 
		"LET", 
		"INT", 
		"REPEATE", 
		"STRING", 
		"DOUBLE", 
		"FLOAT", 
		"BOOL", 
		"VAR", 
		"IN", 
		"PARAMS", 
		"FUNC_CALL", 
		"ARRAY", 
		"FUNC", 
		"RETURN", 
		"SWITCH", 
		"CASE", 
		"DEFAULT", 
		"TYPE", 
		"CASEPARAM", 
		"VARS", 
		"WS", 
		"SL_COMMENT", 
		"ML_COMMENT", 
		"NUMBER", 
		"STRINGVAL", 
		"BOOLVALUE", 
		"IDENT", 
		"ADD", 
		"SUB", 
		"MUL", 
		"DIV", 
		"ASSIGN", 
		"INCR", 
		"DECR", 
		"ADDAS", 
		"SUBAS", 
		"MULAS", 
		"DIVAS", 
		"GE", 
		"LE", 
		"EQ", 
		"NE", 
		"GT", 
		"LT", 
		"'['", 
		"']'", 
		"','", 
		"':'", 
		"'('", 
		"')'", 
		"';'", 
		"'...'", 
		"'->'"
    };

    public const int PRINT = 5;
    public const int STRINGVAL = 43;
    public const int ADD = 46;
    public const int INPUT = 6;
    public const int ARRAY = 30;
    public const int DIVAS = 56;
    public const int VARS = 38;
    public const int VAR = 26;
    public const int LT = 62;
    public const int REPEATE = 21;
    public const int ELSE = 12;
    public const int IF = 11;
    public const int TYPE = 36;
    public const int BOOLVALUE = 44;
    public const int SUB = 47;
    public const int NUMBER = 42;
    public const int IN = 27;
    public const int MUL = 48;
    public const int BLOCK = 7;
    public const int FOR = 14;
    public const int EQ = 59;
    public const int CASE = 34;
    public const int DECR = 52;
    public const int NOT = 17;
    public const int MULAS = 55;
    public const int FUNC_CALL = 29;
    public const int AND = 15;
    public const int NE = 60;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__68 = 68;
    public const int END = 10;
    public const int SWITCH = 33;
    public const int T__69 = 69;
    public const int PARAMS = 28;
    public const int T__63 = 63;
    public const int T__64 = 64;
    public const int PROGRAM = 8;
    public const int T__65 = 65;
    public const int ADDAS = 53;
    public const int T__70 = 70;
    public const int T__71 = 71;
    public const int FLOAT = 24;
    public const int CASEPARAM = 37;
    public const int BEGIN = 9;
    public const int ASSIGN = 50;
    public const int INT = 20;
    public const int RETURN = 32;
    public const int DOUBLE = 23;
    public const int WS = 39;
    public const int EOF = -1;
    public const int GE = 57;
    public const int OR = 16;
    public const int FUNC = 31;
    public const int SUBAS = 54;
    public const int GT = 61;
    public const int DIV = 49;
    public const int IDENT = 45;
    public const int BOOL = 25;
    public const int ML_COMMENT = 41;
    public const int INCR = 51;
    public const int SL_COMMENT = 40;
    public const int STRING = 22;
    public const int LE = 58;
    public const int WHILE = 13;
    public const int LET = 19;
    public const int UNKNOWN = 4;
    public const int DEFAULT = 35;
    public const int FUNC_PARAM = 18;

    // delegates
    // delegators



        public MathExprParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public MathExprParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[103+1];
             
             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return MathExprParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "MathExpr.g"; }
    }


    public class array_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "array"
    // MathExpr.g:87:1: array : IDENT ( '[' add ']' )+ -> ^( ARRAY IDENT ( add )* ) ;
    public MathExprParser.array_return array() // throws RecognitionException [1]
    {   
        MathExprParser.array_return retval = new MathExprParser.array_return();
        retval.Start = input.LT(1);
        int array_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken IDENT1 = null;
        IToken char_literal2 = null;
        IToken char_literal4 = null;
        MathExprParser.add_return add3 = default(MathExprParser.add_return);


        AstNode IDENT1_tree=null;
        AstNode char_literal2_tree=null;
        AstNode char_literal4_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:87:6: ( IDENT ( '[' add ']' )+ -> ^( ARRAY IDENT ( add )* ) )
            // MathExpr.g:87:8: IDENT ( '[' add ']' )+
            {
            	IDENT1=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_array775); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT1);

            	// MathExpr.g:87:14: ( '[' add ']' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 63) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // MathExpr.g:87:15: '[' add ']'
            			    {
            			    	char_literal2=(IToken)Match(input,63,FOLLOW_63_in_array778); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_63.Add(char_literal2);

            			    	PushFollow(FOLLOW_add_in_array780);
            			    	add3 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_add.Add(add3.Tree);
            			    	char_literal4=(IToken)Match(input,64,FOLLOW_64_in_array782); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_64.Add(char_literal4);


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements



            	// AST REWRITE
            	// elements:          IDENT, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 87:29: -> ^( ARRAY IDENT ( add )* )
            	{
            	    // MathExpr.g:87:32: ^( ARRAY IDENT ( add )* )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(ARRAY, "ARRAY"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // MathExpr.g:87:46: ( add )*
            	    while ( stream_add.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_add.NextTree());

            	    }
            	    stream_add.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, array_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "array"

    public class idar_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "idar"
    // MathExpr.g:89:1: idar : ( array | IDENT );
    public MathExprParser.idar_return idar() // throws RecognitionException [1]
    {   
        MathExprParser.idar_return retval = new MathExprParser.idar_return();
        retval.Start = input.LT(1);
        int idar_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken IDENT6 = null;
        MathExprParser.array_return array5 = default(MathExprParser.array_return);


        AstNode IDENT6_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:89:5: ( array | IDENT )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == IDENT) )
            {
                int LA2_1 = input.LA(2);

                if ( (LA2_1 == EOF || LA2_1 == PRINT || (LA2_1 >= BEGIN && LA2_1 <= OR) || LA2_1 == LET || LA2_1 == REPEATE || LA2_1 == VAR || (LA2_1 >= FUNC && LA2_1 <= DEFAULT) || (LA2_1 >= IDENT && LA2_1 <= DECR) || (LA2_1 >= GE && LA2_1 <= LT) || (LA2_1 >= 64 && LA2_1 <= 66) || (LA2_1 >= 68 && LA2_1 <= 70)) )
                {
                    alt2 = 2;
                }
                else if ( (LA2_1 == 63) )
                {
                    alt2 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("", 2, 1, input);

                    throw nvae_d2s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // MathExpr.g:89:7: array
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_array_in_idar804);
                    	array5 = array();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array5.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:89:15: IDENT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IDENT6=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_idar808); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT6_tree = (AstNode)adaptor.Create(IDENT6);
                    		adaptor.AddChild(root_0, IDENT6_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, idar_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "idar"

    public class type_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "type"
    // MathExpr.g:113:1: type : ( INT | STRING | DOUBLE | FLOAT | BOOL | ( '[' type ']' ) -> ^( ARRAY type ) );
    public MathExprParser.type_return type() // throws RecognitionException [1]
    {   
        MathExprParser.type_return retval = new MathExprParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken INT7 = null;
        IToken STRING8 = null;
        IToken DOUBLE9 = null;
        IToken FLOAT10 = null;
        IToken BOOL11 = null;
        IToken char_literal12 = null;
        IToken char_literal14 = null;
        MathExprParser.type_return type13 = default(MathExprParser.type_return);


        AstNode INT7_tree=null;
        AstNode STRING8_tree=null;
        AstNode DOUBLE9_tree=null;
        AstNode FLOAT10_tree=null;
        AstNode BOOL11_tree=null;
        AstNode char_literal12_tree=null;
        AstNode char_literal14_tree=null;
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:113:5: ( INT | STRING | DOUBLE | FLOAT | BOOL | ( '[' type ']' ) -> ^( ARRAY type ) )
            int alt3 = 6;
            switch ( input.LA(1) ) 
            {
            case INT:
            	{
                alt3 = 1;
                }
                break;
            case STRING:
            	{
                alt3 = 2;
                }
                break;
            case DOUBLE:
            	{
                alt3 = 3;
                }
                break;
            case FLOAT:
            	{
                alt3 = 4;
                }
                break;
            case BOOL:
            	{
                alt3 = 5;
                }
                break;
            case 63:
            	{
                alt3 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // MathExpr.g:113:7: INT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	INT7=(IToken)Match(input,INT,FOLLOW_INT_in_type990); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INT7_tree = (AstNode)adaptor.Create(INT7);
                    		adaptor.AddChild(root_0, INT7_tree);
                    	}

                    }
                    break;
                case 2 :
                    // MathExpr.g:113:13: STRING
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	STRING8=(IToken)Match(input,STRING,FOLLOW_STRING_in_type994); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING8_tree = (AstNode)adaptor.Create(STRING8);
                    		adaptor.AddChild(root_0, STRING8_tree);
                    	}

                    }
                    break;
                case 3 :
                    // MathExpr.g:113:22: DOUBLE
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	DOUBLE9=(IToken)Match(input,DOUBLE,FOLLOW_DOUBLE_in_type998); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DOUBLE9_tree = (AstNode)adaptor.Create(DOUBLE9);
                    		adaptor.AddChild(root_0, DOUBLE9_tree);
                    	}

                    }
                    break;
                case 4 :
                    // MathExpr.g:113:31: FLOAT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FLOAT10=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_type1002); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FLOAT10_tree = (AstNode)adaptor.Create(FLOAT10);
                    		adaptor.AddChild(root_0, FLOAT10_tree);
                    	}

                    }
                    break;
                case 5 :
                    // MathExpr.g:113:39: BOOL
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	BOOL11=(IToken)Match(input,BOOL,FOLLOW_BOOL_in_type1006); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BOOL11_tree = (AstNode)adaptor.Create(BOOL11);
                    		adaptor.AddChild(root_0, BOOL11_tree);
                    	}

                    }
                    break;
                case 6 :
                    // MathExpr.g:113:46: ( '[' type ']' )
                    {
                    	// MathExpr.g:113:46: ( '[' type ']' )
                    	// MathExpr.g:113:47: '[' type ']'
                    	{
                    		char_literal12=(IToken)Match(input,63,FOLLOW_63_in_type1011); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_63.Add(char_literal12);

                    		PushFollow(FOLLOW_type_in_type1013);
                    		type13 = type();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_type.Add(type13.Tree);
                    		char_literal14=(IToken)Match(input,64,FOLLOW_64_in_type1015); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_64.Add(char_literal14);


                    	}



                    	// AST REWRITE
                    	// elements:          type
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 113:61: -> ^( ARRAY type )
                    	{
                    	    // MathExpr.g:113:64: ^( ARRAY type )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(ARRAY, "ARRAY"), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, type_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "type"

    public class value_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "value"
    // MathExpr.g:115:1: value : ( NUMBER | STRINGVAL | BOOLVALUE );
    public MathExprParser.value_return value() // throws RecognitionException [1]
    {   
        MathExprParser.value_return retval = new MathExprParser.value_return();
        retval.Start = input.LT(1);
        int value_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set15 = null;

        AstNode set15_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:115:6: ( NUMBER | STRINGVAL | BOOLVALUE )
            // MathExpr.g:
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	set15 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= NUMBER && input.LA(1) <= BOOLVALUE) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (AstNode)adaptor.Create(set15));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, value_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "value"

    public class returnValue_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "returnValue"
    // MathExpr.g:117:1: returnValue : ( term | value | IDENT );
    public MathExprParser.returnValue_return returnValue() // throws RecognitionException [1]
    {   
        MathExprParser.returnValue_return retval = new MathExprParser.returnValue_return();
        retval.Start = input.LT(1);
        int returnValue_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken IDENT18 = null;
        MathExprParser.term_return term16 = default(MathExprParser.term_return);

        MathExprParser.value_return value17 = default(MathExprParser.value_return);


        AstNode IDENT18_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:117:12: ( term | value | IDENT )
            int alt4 = 3;
            switch ( input.LA(1) ) 
            {
            case NOT:
            case INCR:
            case DECR:
            case 67:
            	{
                alt4 = 1;
                }
                break;
            case IDENT:
            	{
                int LA4_2 = input.LA(2);

                if ( (synpred10_MathExpr()) )
                {
                    alt4 = 1;
                }
                else if ( (true) )
                {
                    alt4 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d4s2 =
                        new NoViableAltException("", 4, 2, input);

                    throw nvae_d4s2;
                }
                }
                break;
            case NUMBER:
            case STRINGVAL:
            case BOOLVALUE:
            	{
                int LA4_3 = input.LA(2);

                if ( (synpred10_MathExpr()) )
                {
                    alt4 = 1;
                }
                else if ( (synpred11_MathExpr()) )
                {
                    alt4 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d4s3 =
                        new NoViableAltException("", 4, 3, input);

                    throw nvae_d4s3;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            }

            switch (alt4) 
            {
                case 1 :
                    // MathExpr.g:117:14: term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_term_in_returnValue1047);
                    	term16 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term16.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:117:21: value
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_returnValue1051);
                    	value17 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value17.Tree);

                    }
                    break;
                case 3 :
                    // MathExpr.g:117:29: IDENT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IDENT18=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_returnValue1055); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT18_tree = (AstNode)adaptor.Create(IDENT18);
                    		adaptor.AddChild(root_0, IDENT18_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, returnValue_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "returnValue"

    public class arrayValue_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "arrayValue"
    // MathExpr.g:119:1: arrayValue : ( ( '[' returnValue ( ',' returnValue )* ']' ) | ( '[' arrayValue ( ',' arrayValue )* ']' ) -> ( ^( ARRAY arrayValue ) )* );
    public MathExprParser.arrayValue_return arrayValue() // throws RecognitionException [1]
    {   
        MathExprParser.arrayValue_return retval = new MathExprParser.arrayValue_return();
        retval.Start = input.LT(1);
        int arrayValue_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal19 = null;
        IToken char_literal21 = null;
        IToken char_literal23 = null;
        IToken char_literal24 = null;
        IToken char_literal26 = null;
        IToken char_literal28 = null;
        MathExprParser.returnValue_return returnValue20 = default(MathExprParser.returnValue_return);

        MathExprParser.returnValue_return returnValue22 = default(MathExprParser.returnValue_return);

        MathExprParser.arrayValue_return arrayValue25 = default(MathExprParser.arrayValue_return);

        MathExprParser.arrayValue_return arrayValue27 = default(MathExprParser.arrayValue_return);


        AstNode char_literal19_tree=null;
        AstNode char_literal21_tree=null;
        AstNode char_literal23_tree=null;
        AstNode char_literal24_tree=null;
        AstNode char_literal26_tree=null;
        AstNode char_literal28_tree=null;
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_arrayValue = new RewriteRuleSubtreeStream(adaptor,"rule arrayValue");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:119:11: ( ( '[' returnValue ( ',' returnValue )* ']' ) | ( '[' arrayValue ( ',' arrayValue )* ']' ) -> ( ^( ARRAY arrayValue ) )* )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == 63) )
            {
                int LA7_1 = input.LA(2);

                if ( (LA7_1 == NOT || (LA7_1 >= NUMBER && LA7_1 <= IDENT) || (LA7_1 >= INCR && LA7_1 <= DECR) || LA7_1 == 67) )
                {
                    alt7 = 1;
                }
                else if ( (LA7_1 == 63) )
                {
                    alt7 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d7s1 =
                        new NoViableAltException("", 7, 1, input);

                    throw nvae_d7s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // MathExpr.g:119:12: ( '[' returnValue ( ',' returnValue )* ']' )
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	// MathExpr.g:119:12: ( '[' returnValue ( ',' returnValue )* ']' )
                    	// MathExpr.g:119:13: '[' returnValue ( ',' returnValue )* ']'
                    	{
                    		char_literal19=(IToken)Match(input,63,FOLLOW_63_in_arrayValue1062); if (state.failed) return retval;
                    		PushFollow(FOLLOW_returnValue_in_arrayValue1065);
                    		returnValue20 = returnValue();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnValue20.Tree);
                    		// MathExpr.g:119:30: ( ',' returnValue )*
                    		do 
                    		{
                    		    int alt5 = 2;
                    		    int LA5_0 = input.LA(1);

                    		    if ( (LA5_0 == 65) )
                    		    {
                    		        alt5 = 1;
                    		    }


                    		    switch (alt5) 
                    			{
                    				case 1 :
                    				    // MathExpr.g:119:31: ',' returnValue
                    				    {
                    				    	char_literal21=(IToken)Match(input,65,FOLLOW_65_in_arrayValue1068); if (state.failed) return retval;
                    				    	PushFollow(FOLLOW_returnValue_in_arrayValue1071);
                    				    	returnValue22 = returnValue();
                    				    	state.followingStackPointer--;
                    				    	if (state.failed) return retval;
                    				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnValue22.Tree);

                    				    }
                    				    break;

                    				default:
                    				    goto loop5;
                    		    }
                    		} while (true);

                    		loop5:
                    			;	// Stops C# compiler whining that label 'loop5' has no statements

                    		char_literal23=(IToken)Match(input,64,FOLLOW_64_in_arrayValue1075); if (state.failed) return retval;

                    	}


                    }
                    break;
                case 2 :
                    // MathExpr.g:119:59: ( '[' arrayValue ( ',' arrayValue )* ']' )
                    {
                    	// MathExpr.g:119:59: ( '[' arrayValue ( ',' arrayValue )* ']' )
                    	// MathExpr.g:119:60: '[' arrayValue ( ',' arrayValue )* ']'
                    	{
                    		char_literal24=(IToken)Match(input,63,FOLLOW_63_in_arrayValue1083); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_63.Add(char_literal24);

                    		PushFollow(FOLLOW_arrayValue_in_arrayValue1085);
                    		arrayValue25 = arrayValue();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_arrayValue.Add(arrayValue25.Tree);
                    		// MathExpr.g:119:75: ( ',' arrayValue )*
                    		do 
                    		{
                    		    int alt6 = 2;
                    		    int LA6_0 = input.LA(1);

                    		    if ( (LA6_0 == 65) )
                    		    {
                    		        alt6 = 1;
                    		    }


                    		    switch (alt6) 
                    			{
                    				case 1 :
                    				    // MathExpr.g:119:76: ',' arrayValue
                    				    {
                    				    	char_literal26=(IToken)Match(input,65,FOLLOW_65_in_arrayValue1088); if (state.failed) return retval; 
                    				    	if ( (state.backtracking==0) ) stream_65.Add(char_literal26);

                    				    	PushFollow(FOLLOW_arrayValue_in_arrayValue1090);
                    				    	arrayValue27 = arrayValue();
                    				    	state.followingStackPointer--;
                    				    	if (state.failed) return retval;
                    				    	if ( (state.backtracking==0) ) stream_arrayValue.Add(arrayValue27.Tree);

                    				    }
                    				    break;

                    				default:
                    				    goto loop6;
                    		    }
                    		} while (true);

                    		loop6:
                    			;	// Stops C# compiler whining that label 'loop6' has no statements

                    		char_literal28=(IToken)Match(input,64,FOLLOW_64_in_arrayValue1094); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_64.Add(char_literal28);


                    	}



                    	// AST REWRITE
                    	// elements:          arrayValue
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 119:99: -> ( ^( ARRAY arrayValue ) )*
                    	{
                    	    // MathExpr.g:119:102: ( ^( ARRAY arrayValue ) )*
                    	    while ( stream_arrayValue.HasNext() )
                    	    {
                    	        // MathExpr.g:119:102: ^( ARRAY arrayValue )
                    	        {
                    	        AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	        root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(ARRAY, "ARRAY"), root_1);

                    	        adaptor.AddChild(root_1, stream_arrayValue.NextTree());

                    	        adaptor.AddChild(root_0, root_1);
                    	        }

                    	    }
                    	    stream_arrayValue.Reset();

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, arrayValue_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arrayValue"

    public class crement_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "crement"
    // MathExpr.g:121:1: crement : ( INCR idar | idar INCR | DECR idar | idar DECR );
    public MathExprParser.crement_return crement() // throws RecognitionException [1]
    {   
        MathExprParser.crement_return retval = new MathExprParser.crement_return();
        retval.Start = input.LT(1);
        int crement_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken INCR29 = null;
        IToken INCR32 = null;
        IToken DECR33 = null;
        IToken DECR36 = null;
        MathExprParser.idar_return idar30 = default(MathExprParser.idar_return);

        MathExprParser.idar_return idar31 = default(MathExprParser.idar_return);

        MathExprParser.idar_return idar34 = default(MathExprParser.idar_return);

        MathExprParser.idar_return idar35 = default(MathExprParser.idar_return);


        AstNode INCR29_tree=null;
        AstNode INCR32_tree=null;
        AstNode DECR33_tree=null;
        AstNode DECR36_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:121:8: ( INCR idar | idar INCR | DECR idar | idar DECR )
            int alt8 = 4;
            switch ( input.LA(1) ) 
            {
            case INCR:
            	{
                alt8 = 1;
                }
                break;
            case IDENT:
            	{
                int LA8_2 = input.LA(2);

                if ( (synpred16_MathExpr()) )
                {
                    alt8 = 2;
                }
                else if ( (true) )
                {
                    alt8 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d8s2 =
                        new NoViableAltException("", 8, 2, input);

                    throw nvae_d8s2;
                }
                }
                break;
            case DECR:
            	{
                alt8 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // MathExpr.g:121:10: INCR idar
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	INCR29=(IToken)Match(input,INCR,FOLLOW_INCR_in_crement1112); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INCR29_tree = (AstNode)adaptor.Create(INCR29);
                    		root_0 = (AstNode)adaptor.BecomeRoot(INCR29_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_idar_in_crement1115);
                    	idar30 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idar30.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:121:23: idar INCR
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idar_in_crement1119);
                    	idar31 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idar31.Tree);
                    	INCR32=(IToken)Match(input,INCR,FOLLOW_INCR_in_crement1121); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INCR32_tree = (AstNode)adaptor.Create(INCR32);
                    		root_0 = (AstNode)adaptor.BecomeRoot(INCR32_tree, root_0);
                    	}

                    }
                    break;
                case 3 :
                    // MathExpr.g:121:36: DECR idar
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	DECR33=(IToken)Match(input,DECR,FOLLOW_DECR_in_crement1126); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DECR33_tree = (AstNode)adaptor.Create(DECR33);
                    		root_0 = (AstNode)adaptor.BecomeRoot(DECR33_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_idar_in_crement1129);
                    	idar34 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idar34.Tree);

                    }
                    break;
                case 4 :
                    // MathExpr.g:121:49: idar DECR
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idar_in_crement1133);
                    	idar35 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idar35.Tree);
                    	DECR36=(IToken)Match(input,DECR,FOLLOW_DECR_in_crement1135); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DECR36_tree = (AstNode)adaptor.Create(DECR36);
                    		root_0 = (AstNode)adaptor.BecomeRoot(DECR36_tree, root_0);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, crement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "crement"

    public class allassign_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "allassign"
    // MathExpr.g:123:1: allassign : ( ASSIGN | ADDAS | SUBAS | MULAS | DIVAS );
    public MathExprParser.allassign_return allassign() // throws RecognitionException [1]
    {   
        MathExprParser.allassign_return retval = new MathExprParser.allassign_return();
        retval.Start = input.LT(1);
        int allassign_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set37 = null;

        AstNode set37_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:123:10: ( ASSIGN | ADDAS | SUBAS | MULAS | DIVAS )
            // MathExpr.g:
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	set37 = (IToken)input.LT(1);
            	if ( input.LA(1) == ASSIGN || (input.LA(1) >= ADDAS && input.LA(1) <= DIVAS) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (AstNode)adaptor.Create(set37));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, allassign_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "allassign"

    public class swcase_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "swcase"
    // MathExpr.g:125:1: swcase : ( CASE returnValue ( ',' returnValue )* ':' expr )* -> ^( CASE ^( CASEPARAM ( returnValue )* ) expr ) ;
    public MathExprParser.swcase_return swcase() // throws RecognitionException [1]
    {   
        MathExprParser.swcase_return retval = new MathExprParser.swcase_return();
        retval.Start = input.LT(1);
        int swcase_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken CASE38 = null;
        IToken char_literal40 = null;
        IToken char_literal42 = null;
        MathExprParser.returnValue_return returnValue39 = default(MathExprParser.returnValue_return);

        MathExprParser.returnValue_return returnValue41 = default(MathExprParser.returnValue_return);

        MathExprParser.expr_return expr43 = default(MathExprParser.expr_return);


        AstNode CASE38_tree=null;
        AstNode char_literal40_tree=null;
        AstNode char_literal42_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleTokenStream stream_CASE = new RewriteRuleTokenStream(adaptor,"token CASE");
        RewriteRuleSubtreeStream stream_returnValue = new RewriteRuleSubtreeStream(adaptor,"rule returnValue");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:125:7: ( ( CASE returnValue ( ',' returnValue )* ':' expr )* -> ^( CASE ^( CASEPARAM ( returnValue )* ) expr ) )
            // MathExpr.g:125:10: ( CASE returnValue ( ',' returnValue )* ':' expr )*
            {
            	// MathExpr.g:125:10: ( CASE returnValue ( ',' returnValue )* ':' expr )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == CASE) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MathExpr.g:125:11: CASE returnValue ( ',' returnValue )* ':' expr
            			    {
            			    	CASE38=(IToken)Match(input,CASE,FOLLOW_CASE_in_swcase1169); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_CASE.Add(CASE38);

            			    	PushFollow(FOLLOW_returnValue_in_swcase1171);
            			    	returnValue39 = returnValue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue39.Tree);
            			    	// MathExpr.g:125:28: ( ',' returnValue )*
            			    	do 
            			    	{
            			    	    int alt9 = 2;
            			    	    int LA9_0 = input.LA(1);

            			    	    if ( (LA9_0 == 65) )
            			    	    {
            			    	        alt9 = 1;
            			    	    }


            			    	    switch (alt9) 
            			    		{
            			    			case 1 :
            			    			    // MathExpr.g:125:29: ',' returnValue
            			    			    {
            			    			    	char_literal40=(IToken)Match(input,65,FOLLOW_65_in_swcase1174); if (state.failed) return retval; 
            			    			    	if ( (state.backtracking==0) ) stream_65.Add(char_literal40);

            			    			    	PushFollow(FOLLOW_returnValue_in_swcase1176);
            			    			    	returnValue41 = returnValue();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue41.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop9;
            			    	    }
            			    	} while (true);

            			    	loop9:
            			    		;	// Stops C# compiler whining that label 'loop9' has no statements

            			    	char_literal42=(IToken)Match(input,66,FOLLOW_66_in_swcase1180); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_66.Add(char_literal42);

            			    	PushFollow(FOLLOW_expr_in_swcase1182);
            			    	expr43 = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expr.Add(expr43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements



            	// AST REWRITE
            	// elements:          expr, CASE, returnValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 125:60: -> ^( CASE ^( CASEPARAM ( returnValue )* ) expr )
            	{
            	    // MathExpr.g:125:63: ^( CASE ^( CASEPARAM ( returnValue )* ) expr )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot(stream_CASE.NextNode(), root_1);

            	    // MathExpr.g:125:70: ^( CASEPARAM ( returnValue )* )
            	    {
            	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	    root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(CASEPARAM, "CASEPARAM"), root_2);

            	    // MathExpr.g:125:82: ( returnValue )*
            	    while ( stream_returnValue.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_returnValue.NextTree());

            	    }
            	    stream_returnValue.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_expr.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, swcase_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "swcase"

    public class paramms_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "paramms"
    // MathExpr.g:127:1: paramms : returnValue ( ',' returnValue )* -> ^( PARAMS ( returnValue )* ) ;
    public MathExprParser.paramms_return paramms() // throws RecognitionException [1]
    {   
        MathExprParser.paramms_return retval = new MathExprParser.paramms_return();
        retval.Start = input.LT(1);
        int paramms_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal45 = null;
        MathExprParser.returnValue_return returnValue44 = default(MathExprParser.returnValue_return);

        MathExprParser.returnValue_return returnValue46 = default(MathExprParser.returnValue_return);


        AstNode char_literal45_tree=null;
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_returnValue = new RewriteRuleSubtreeStream(adaptor,"rule returnValue");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:127:8: ( returnValue ( ',' returnValue )* -> ^( PARAMS ( returnValue )* ) )
            // MathExpr.g:128:1: returnValue ( ',' returnValue )*
            {
            	PushFollow(FOLLOW_returnValue_in_paramms1210);
            	returnValue44 = returnValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue44.Tree);
            	// MathExpr.g:128:13: ( ',' returnValue )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 65) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MathExpr.g:128:14: ',' returnValue
            			    {
            			    	char_literal45=(IToken)Match(input,65,FOLLOW_65_in_paramms1213); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_65.Add(char_literal45);

            			    	PushFollow(FOLLOW_returnValue_in_paramms1215);
            			    	returnValue46 = returnValue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue46.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements



            	// AST REWRITE
            	// elements:          returnValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 128:32: -> ^( PARAMS ( returnValue )* )
            	{
            	    // MathExpr.g:128:35: ^( PARAMS ( returnValue )* )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PARAMS, "PARAMS"), root_1);

            	    // MathExpr.g:128:44: ( returnValue )*
            	    while ( stream_returnValue.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_returnValue.NextTree());

            	    }
            	    stream_returnValue.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, paramms_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "paramms"

    public class func_params_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "func_params"
    // MathExpr.g:131:1: func_params : IDENT ':' type ( ',' IDENT ':' type )* -> ^( FUNC_PARAM ( IDENT type )* ) ;
    public MathExprParser.func_params_return func_params() // throws RecognitionException [1]
    {   
        MathExprParser.func_params_return retval = new MathExprParser.func_params_return();
        retval.Start = input.LT(1);
        int func_params_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken IDENT47 = null;
        IToken char_literal48 = null;
        IToken char_literal50 = null;
        IToken IDENT51 = null;
        IToken char_literal52 = null;
        MathExprParser.type_return type49 = default(MathExprParser.type_return);

        MathExprParser.type_return type53 = default(MathExprParser.type_return);


        AstNode IDENT47_tree=null;
        AstNode char_literal48_tree=null;
        AstNode char_literal50_tree=null;
        AstNode IDENT51_tree=null;
        AstNode char_literal52_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:131:12: ( IDENT ':' type ( ',' IDENT ':' type )* -> ^( FUNC_PARAM ( IDENT type )* ) )
            // MathExpr.g:132:1: IDENT ':' type ( ',' IDENT ':' type )*
            {
            	IDENT47=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_params1234); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT47);

            	char_literal48=(IToken)Match(input,66,FOLLOW_66_in_func_params1236); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_66.Add(char_literal48);

            	PushFollow(FOLLOW_type_in_func_params1238);
            	type49 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type49.Tree);
            	// MathExpr.g:132:16: ( ',' IDENT ':' type )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 65) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // MathExpr.g:132:17: ',' IDENT ':' type
            			    {
            			    	char_literal50=(IToken)Match(input,65,FOLLOW_65_in_func_params1241); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_65.Add(char_literal50);

            			    	IDENT51=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_params1243); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT51);

            			    	char_literal52=(IToken)Match(input,66,FOLLOW_66_in_func_params1245); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_66.Add(char_literal52);

            			    	PushFollow(FOLLOW_type_in_func_params1247);
            			    	type53 = type();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_type.Add(type53.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements



            	// AST REWRITE
            	// elements:          IDENT, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 132:38: -> ^( FUNC_PARAM ( IDENT type )* )
            	{
            	    // MathExpr.g:132:41: ^( FUNC_PARAM ( IDENT type )* )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(FUNC_PARAM, "FUNC_PARAM"), root_1);

            	    // MathExpr.g:132:54: ( IDENT type )*
            	    while ( stream_IDENT.HasNext() || stream_type.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	        adaptor.AddChild(root_1, stream_type.NextTree());

            	    }
            	    stream_IDENT.Reset();
            	    stream_type.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, func_params_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "func_params"

    public class func_call_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "func_call"
    // MathExpr.g:135:1: func_call : IDENT '(' ( paramms )? ')' -> ^( FUNC_CALL IDENT ( paramms )? ) ;
    public MathExprParser.func_call_return func_call() // throws RecognitionException [1]
    {   
        MathExprParser.func_call_return retval = new MathExprParser.func_call_return();
        retval.Start = input.LT(1);
        int func_call_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken IDENT54 = null;
        IToken char_literal55 = null;
        IToken char_literal57 = null;
        MathExprParser.paramms_return paramms56 = default(MathExprParser.paramms_return);


        AstNode IDENT54_tree=null;
        AstNode char_literal55_tree=null;
        AstNode char_literal57_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleSubtreeStream stream_paramms = new RewriteRuleSubtreeStream(adaptor,"rule paramms");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:135:10: ( IDENT '(' ( paramms )? ')' -> ^( FUNC_CALL IDENT ( paramms )? ) )
            // MathExpr.g:136:1: IDENT '(' ( paramms )? ')'
            {
            	IDENT54=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_call1271); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT54);

            	char_literal55=(IToken)Match(input,67,FOLLOW_67_in_func_call1273); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_67.Add(char_literal55);

            	// MathExpr.g:136:11: ( paramms )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == NOT || (LA13_0 >= NUMBER && LA13_0 <= IDENT) || (LA13_0 >= INCR && LA13_0 <= DECR) || LA13_0 == 67) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // MathExpr.g:0:0: paramms
            	        {
            	        	PushFollow(FOLLOW_paramms_in_func_call1275);
            	        	paramms56 = paramms();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_paramms.Add(paramms56.Tree);

            	        }
            	        break;

            	}

            	char_literal57=(IToken)Match(input,68,FOLLOW_68_in_func_call1278); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_68.Add(char_literal57);



            	// AST REWRITE
            	// elements:          IDENT, paramms
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 136:24: -> ^( FUNC_CALL IDENT ( paramms )? )
            	{
            	    // MathExpr.g:136:27: ^( FUNC_CALL IDENT ( paramms )? )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // MathExpr.g:136:45: ( paramms )?
            	    if ( stream_paramms.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_paramms.NextTree());

            	    }
            	    stream_paramms.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, func_call_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "func_call"

    public class group_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "group"
    // MathExpr.g:139:1: group : ( groupExpr | groupInit );
    public MathExprParser.group_return group() // throws RecognitionException [1]
    {   
        MathExprParser.group_return retval = new MathExprParser.group_return();
        retval.Start = input.LT(1);
        int group_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.groupExpr_return groupExpr58 = default(MathExprParser.groupExpr_return);

        MathExprParser.groupInit_return groupInit59 = default(MathExprParser.groupInit_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:139:6: ( groupExpr | groupInit )
            int alt14 = 2;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            	{
                int LA14_1 = input.LA(2);

                if ( (synpred27_MathExpr()) )
                {
                    alt14 = 1;
                }
                else if ( (true) )
                {
                    alt14 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d14s1 =
                        new NoViableAltException("", 14, 1, input);

                    throw nvae_d14s1;
                }
                }
                break;
            case INCR:
            case DECR:
            	{
                alt14 = 1;
                }
                break;
            case NUMBER:
            case STRINGVAL:
            case BOOLVALUE:
            case 67:
            	{
                alt14 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            }

            switch (alt14) 
            {
                case 1 :
                    // MathExpr.g:140:2: groupExpr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_groupExpr_in_group1298);
                    	groupExpr58 = groupExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr58.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:140:15: groupInit
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_groupInit_in_group1303);
                    	groupInit59 = groupInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupInit59.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, group_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "group"

    public class groupInit_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "groupInit"
    // MathExpr.g:143:1: groupInit : ( '(' term ')' | IDENT | value | array );
    public MathExprParser.groupInit_return groupInit() // throws RecognitionException [1]
    {   
        MathExprParser.groupInit_return retval = new MathExprParser.groupInit_return();
        retval.Start = input.LT(1);
        int groupInit_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal60 = null;
        IToken char_literal62 = null;
        IToken IDENT63 = null;
        MathExprParser.term_return term61 = default(MathExprParser.term_return);

        MathExprParser.value_return value64 = default(MathExprParser.value_return);

        MathExprParser.array_return array65 = default(MathExprParser.array_return);


        AstNode char_literal60_tree=null;
        AstNode char_literal62_tree=null;
        AstNode IDENT63_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:143:10: ( '(' term ')' | IDENT | value | array )
            int alt15 = 4;
            switch ( input.LA(1) ) 
            {
            case 67:
            	{
                alt15 = 1;
                }
                break;
            case IDENT:
            	{
                int LA15_2 = input.LA(2);

                if ( (LA15_2 == EOF || LA15_2 == PRINT || (LA15_2 >= BEGIN && LA15_2 <= OR) || LA15_2 == LET || LA15_2 == REPEATE || LA15_2 == VAR || (LA15_2 >= FUNC && LA15_2 <= DEFAULT) || (LA15_2 >= IDENT && LA15_2 <= DIV) || (LA15_2 >= INCR && LA15_2 <= DECR) || (LA15_2 >= GE && LA15_2 <= LT) || (LA15_2 >= 64 && LA15_2 <= 66) || (LA15_2 >= 68 && LA15_2 <= 70)) )
                {
                    alt15 = 2;
                }
                else if ( (LA15_2 == 63) )
                {
                    alt15 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d15s2 =
                        new NoViableAltException("", 15, 2, input);

                    throw nvae_d15s2;
                }
                }
                break;
            case NUMBER:
            case STRINGVAL:
            case BOOLVALUE:
            	{
                alt15 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // MathExpr.g:144:3: '(' term ')'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	char_literal60=(IToken)Match(input,67,FOLLOW_67_in_groupInit1313); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_groupInit1316);
                    	term61 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term61.Tree);
                    	char_literal62=(IToken)Match(input,68,FOLLOW_68_in_groupInit1318); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MathExpr.g:145:3: IDENT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IDENT63=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_groupInit1323); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT63_tree = (AstNode)adaptor.Create(IDENT63);
                    		adaptor.AddChild(root_0, IDENT63_tree);
                    	}

                    }
                    break;
                case 3 :
                    // MathExpr.g:146:3: value
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_groupInit1328);
                    	value64 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value64.Tree);

                    }
                    break;
                case 4 :
                    // MathExpr.g:147:3: array
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_array_in_groupInit1332);
                    	array65 = array();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array65.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, groupInit_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "groupInit"

    public class groupExpr_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "groupExpr"
    // MathExpr.g:150:1: groupExpr : ( func_call | crement );
    public MathExprParser.groupExpr_return groupExpr() // throws RecognitionException [1]
    {   
        MathExprParser.groupExpr_return retval = new MathExprParser.groupExpr_return();
        retval.Start = input.LT(1);
        int groupExpr_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.func_call_return func_call66 = default(MathExprParser.func_call_return);

        MathExprParser.crement_return crement67 = default(MathExprParser.crement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:150:10: ( func_call | crement )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == IDENT) )
            {
                int LA16_1 = input.LA(2);

                if ( (LA16_1 == 67) )
                {
                    alt16 = 1;
                }
                else if ( ((LA16_1 >= INCR && LA16_1 <= DECR) || LA16_1 == 63) )
                {
                    alt16 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s1 =
                        new NoViableAltException("", 16, 1, input);

                    throw nvae_d16s1;
                }
            }
            else if ( ((LA16_0 >= INCR && LA16_0 <= DECR)) )
            {
                alt16 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // MathExpr.g:151:2: func_call
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_groupExpr1341);
                    	func_call66 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call66.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:152:5: crement
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_crement_in_groupExpr1347);
                    	crement67 = crement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, crement67.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, groupExpr_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "groupExpr"

    public class not_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "not"
    // MathExpr.g:156:1: not : ( NOT group | group );
    public MathExprParser.not_return not() // throws RecognitionException [1]
    {   
        MathExprParser.not_return retval = new MathExprParser.not_return();
        retval.Start = input.LT(1);
        int not_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken NOT68 = null;
        MathExprParser.group_return group69 = default(MathExprParser.group_return);

        MathExprParser.group_return group70 = default(MathExprParser.group_return);


        AstNode NOT68_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:156:4: ( NOT group | group )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == NOT) )
            {
                alt17 = 1;
            }
            else if ( ((LA17_0 >= NUMBER && LA17_0 <= IDENT) || (LA17_0 >= INCR && LA17_0 <= DECR) || LA17_0 == 67) )
            {
                alt17 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // MathExpr.g:157:3: NOT group
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	NOT68=(IToken)Match(input,NOT,FOLLOW_NOT_in_not1358); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT68_tree = (AstNode)adaptor.Create(NOT68);
                    		root_0 = (AstNode)adaptor.BecomeRoot(NOT68_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_group_in_not1361);
                    	group69 = group();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group69.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:158:3: group
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_group_in_not1365);
                    	group70 = group();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group70.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, not_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "not"

    public class mult_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "mult"
    // MathExpr.g:161:1: mult : not ( ( MUL | DIV ) not )* ;
    public MathExprParser.mult_return mult() // throws RecognitionException [1]
    {   
        MathExprParser.mult_return retval = new MathExprParser.mult_return();
        retval.Start = input.LT(1);
        int mult_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set72 = null;
        MathExprParser.not_return not71 = default(MathExprParser.not_return);

        MathExprParser.not_return not73 = default(MathExprParser.not_return);


        AstNode set72_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:161:5: ( not ( ( MUL | DIV ) not )* )
            // MathExpr.g:161:7: not ( ( MUL | DIV ) not )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_not_in_mult1373);
            	not71 = not();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not71.Tree);
            	// MathExpr.g:161:11: ( ( MUL | DIV ) not )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= MUL && LA18_0 <= DIV)) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // MathExpr.g:161:13: ( MUL | DIV ) not
            			    {
            			    	set72=(IToken)input.LT(1);
            			    	set72 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MUL && input.LA(1) <= DIV) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set72), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_not_in_mult1388);
            			    	not73 = not();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not73.Tree);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, mult_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "mult"

    public class add_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "add"
    // MathExpr.g:162:1: add : mult ( ( ADD | SUB ) mult )* ;
    public MathExprParser.add_return add() // throws RecognitionException [1]
    {   
        MathExprParser.add_return retval = new MathExprParser.add_return();
        retval.Start = input.LT(1);
        int add_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set75 = null;
        MathExprParser.mult_return mult74 = default(MathExprParser.mult_return);

        MathExprParser.mult_return mult76 = default(MathExprParser.mult_return);


        AstNode set75_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:162:4: ( mult ( ( ADD | SUB ) mult )* )
            // MathExpr.g:162:7: mult ( ( ADD | SUB ) mult )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1400);
            	mult74 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult74.Tree);
            	// MathExpr.g:162:13: ( ( ADD | SUB ) mult )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( ((LA19_0 >= ADD && LA19_0 <= SUB)) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // MathExpr.g:162:15: ( ADD | SUB ) mult
            			    {
            			    	set75=(IToken)input.LT(1);
            			    	set75 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= ADD && input.LA(1) <= SUB) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set75), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add1416);
            			    	mult76 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult76.Tree);

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, add_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "add"

    public class term_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "term"
    // MathExpr.g:163:1: term : or_logic ;
    public MathExprParser.term_return term() // throws RecognitionException [1]
    {   
        MathExprParser.term_return retval = new MathExprParser.term_return();
        retval.Start = input.LT(1);
        int term_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.or_logic_return or_logic77 = default(MathExprParser.or_logic_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:163:5: ( or_logic )
            // MathExpr.g:163:7: or_logic
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_or_logic_in_term1428);
            	or_logic77 = or_logic();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or_logic77.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, term_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "term"

    public class compare_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "compare"
    // MathExpr.g:165:1: compare : add ( ( GE | LE | EQ | NE | LT | GT ) add )? ;
    public MathExprParser.compare_return compare() // throws RecognitionException [1]
    {   
        MathExprParser.compare_return retval = new MathExprParser.compare_return();
        retval.Start = input.LT(1);
        int compare_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set79 = null;
        MathExprParser.add_return add78 = default(MathExprParser.add_return);

        MathExprParser.add_return add80 = default(MathExprParser.add_return);


        AstNode set79_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:165:8: ( add ( ( GE | LE | EQ | NE | LT | GT ) add )? )
            // MathExpr.g:166:3: add ( ( GE | LE | EQ | NE | LT | GT ) add )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_compare1440);
            	add78 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add78.Tree);
            	// MathExpr.g:166:7: ( ( GE | LE | EQ | NE | LT | GT ) add )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( ((LA20_0 >= GE && LA20_0 <= LT)) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // MathExpr.g:166:8: ( GE | LE | EQ | NE | LT | GT ) add
            	        {
            	        	set79=(IToken)input.LT(1);
            	        	set79 = (IToken)input.LT(1);
            	        	if ( (input.LA(1) >= GE && input.LA(1) <= LT) ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set79), root_0);
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	PushFollow(FOLLOW_add_in_compare1458);
            	        	add80 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add80.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, compare_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "compare"

    public class and_logic_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "and_logic"
    // MathExpr.g:169:1: and_logic : compare ( AND compare )* ;
    public MathExprParser.and_logic_return and_logic() // throws RecognitionException [1]
    {   
        MathExprParser.and_logic_return retval = new MathExprParser.and_logic_return();
        retval.Start = input.LT(1);
        int and_logic_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken AND82 = null;
        MathExprParser.compare_return compare81 = default(MathExprParser.compare_return);

        MathExprParser.compare_return compare83 = default(MathExprParser.compare_return);


        AstNode AND82_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:169:10: ( compare ( AND compare )* )
            // MathExpr.g:169:12: compare ( AND compare )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_compare_in_and_logic1468);
            	compare81 = compare();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare81.Tree);
            	// MathExpr.g:169:20: ( AND compare )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == AND) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // MathExpr.g:169:21: AND compare
            			    {
            			    	AND82=(IToken)Match(input,AND,FOLLOW_AND_in_and_logic1471); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{AND82_tree = (AstNode)adaptor.Create(AND82);
            			    		root_0 = (AstNode)adaptor.BecomeRoot(AND82_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_compare_in_and_logic1474);
            			    	compare83 = compare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare83.Tree);

            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, and_logic_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "and_logic"

    public class or_logic_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "or_logic"
    // MathExpr.g:170:1: or_logic : and_logic ( OR and_logic )* ;
    public MathExprParser.or_logic_return or_logic() // throws RecognitionException [1]
    {   
        MathExprParser.or_logic_return retval = new MathExprParser.or_logic_return();
        retval.Start = input.LT(1);
        int or_logic_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken OR85 = null;
        MathExprParser.and_logic_return and_logic84 = default(MathExprParser.and_logic_return);

        MathExprParser.and_logic_return and_logic86 = default(MathExprParser.and_logic_return);


        AstNode OR85_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:170:9: ( and_logic ( OR and_logic )* )
            // MathExpr.g:170:11: and_logic ( OR and_logic )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_and_logic_in_or_logic1483);
            	and_logic84 = and_logic();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic84.Tree);
            	// MathExpr.g:170:21: ( OR and_logic )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == OR) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // MathExpr.g:170:22: OR and_logic
            			    {
            			    	OR85=(IToken)Match(input,OR,FOLLOW_OR_in_or_logic1486); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{OR85_tree = (AstNode)adaptor.Create(OR85);
            			    		root_0 = (AstNode)adaptor.BecomeRoot(OR85_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_and_logic_in_or_logic1489);
            			    	and_logic86 = and_logic();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic86.Tree);

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, or_logic_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "or_logic"

    public class expr_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "expr"
    // MathExpr.g:174:1: expr : ( BEGIN exprList END -> ^( BLOCK ( exprList )? ) | IDENT allassign term | IF term expr ( ELSE expr )? | WHILE term expr | FOR ( ( VAR )? IDENT ASSIGN term ';' ) compare ';' ( groupExpr ';' ) expr | LET IDENT ( ':' type )? ( ASSIGN returnValue )? | VAR idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? ( ',' idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? )* -> ^( VAR ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ( ^( ARRAY arrayValue ) )? ) )* ) | FOR ( VAR )? IDENT IN term '...' term expr | PRINT '(' STRINGVAL ')' | groupExpr | REPEATE expr WHILE term -> ^( REPEATE term expr ) | FUNC IDENT '(' ( func_params )? ')' ( '->' type )? expr | RETURN returnValue | SWITCH IDENT '{' ( swcase )? ( DEFAULT ':' expr )? '}' -> ^( SWITCH IDENT ( swcase )? ( DEFAULT expr )? ) );
    public MathExprParser.expr_return expr() // throws RecognitionException [1]
    {   
        MathExprParser.expr_return retval = new MathExprParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken BEGIN87 = null;
        IToken END89 = null;
        IToken IDENT90 = null;
        IToken IF93 = null;
        IToken ELSE96 = null;
        IToken WHILE98 = null;
        IToken FOR101 = null;
        IToken VAR102 = null;
        IToken IDENT103 = null;
        IToken ASSIGN104 = null;
        IToken char_literal106 = null;
        IToken char_literal108 = null;
        IToken char_literal110 = null;
        IToken LET112 = null;
        IToken IDENT113 = null;
        IToken char_literal114 = null;
        IToken ASSIGN116 = null;
        IToken VAR118 = null;
        IToken char_literal120 = null;
        IToken ASSIGN122 = null;
        IToken char_literal125 = null;
        IToken char_literal127 = null;
        IToken ASSIGN129 = null;
        IToken FOR132 = null;
        IToken VAR133 = null;
        IToken IDENT134 = null;
        IToken IN135 = null;
        IToken string_literal137 = null;
        IToken PRINT140 = null;
        IToken char_literal141 = null;
        IToken STRINGVAL142 = null;
        IToken char_literal143 = null;
        IToken REPEATE145 = null;
        IToken WHILE147 = null;
        IToken FUNC149 = null;
        IToken IDENT150 = null;
        IToken char_literal151 = null;
        IToken char_literal153 = null;
        IToken string_literal154 = null;
        IToken RETURN157 = null;
        IToken SWITCH159 = null;
        IToken IDENT160 = null;
        IToken char_literal161 = null;
        IToken DEFAULT163 = null;
        IToken char_literal164 = null;
        IToken char_literal166 = null;
        MathExprParser.exprList_return exprList88 = default(MathExprParser.exprList_return);

        MathExprParser.allassign_return allassign91 = default(MathExprParser.allassign_return);

        MathExprParser.term_return term92 = default(MathExprParser.term_return);

        MathExprParser.term_return term94 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr95 = default(MathExprParser.expr_return);

        MathExprParser.expr_return expr97 = default(MathExprParser.expr_return);

        MathExprParser.term_return term99 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr100 = default(MathExprParser.expr_return);

        MathExprParser.term_return term105 = default(MathExprParser.term_return);

        MathExprParser.compare_return compare107 = default(MathExprParser.compare_return);

        MathExprParser.groupExpr_return groupExpr109 = default(MathExprParser.groupExpr_return);

        MathExprParser.expr_return expr111 = default(MathExprParser.expr_return);

        MathExprParser.type_return type115 = default(MathExprParser.type_return);

        MathExprParser.returnValue_return returnValue117 = default(MathExprParser.returnValue_return);

        MathExprParser.idar_return idar119 = default(MathExprParser.idar_return);

        MathExprParser.type_return type121 = default(MathExprParser.type_return);

        MathExprParser.returnValue_return returnValue123 = default(MathExprParser.returnValue_return);

        MathExprParser.arrayValue_return arrayValue124 = default(MathExprParser.arrayValue_return);

        MathExprParser.idar_return idar126 = default(MathExprParser.idar_return);

        MathExprParser.type_return type128 = default(MathExprParser.type_return);

        MathExprParser.returnValue_return returnValue130 = default(MathExprParser.returnValue_return);

        MathExprParser.arrayValue_return arrayValue131 = default(MathExprParser.arrayValue_return);

        MathExprParser.term_return term136 = default(MathExprParser.term_return);

        MathExprParser.term_return term138 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr139 = default(MathExprParser.expr_return);

        MathExprParser.groupExpr_return groupExpr144 = default(MathExprParser.groupExpr_return);

        MathExprParser.expr_return expr146 = default(MathExprParser.expr_return);

        MathExprParser.term_return term148 = default(MathExprParser.term_return);

        MathExprParser.func_params_return func_params152 = default(MathExprParser.func_params_return);

        MathExprParser.type_return type155 = default(MathExprParser.type_return);

        MathExprParser.expr_return expr156 = default(MathExprParser.expr_return);

        MathExprParser.returnValue_return returnValue158 = default(MathExprParser.returnValue_return);

        MathExprParser.swcase_return swcase162 = default(MathExprParser.swcase_return);

        MathExprParser.expr_return expr165 = default(MathExprParser.expr_return);


        AstNode BEGIN87_tree=null;
        AstNode END89_tree=null;
        AstNode IDENT90_tree=null;
        AstNode IF93_tree=null;
        AstNode ELSE96_tree=null;
        AstNode WHILE98_tree=null;
        AstNode FOR101_tree=null;
        AstNode VAR102_tree=null;
        AstNode IDENT103_tree=null;
        AstNode ASSIGN104_tree=null;
        AstNode char_literal106_tree=null;
        AstNode char_literal108_tree=null;
        AstNode char_literal110_tree=null;
        AstNode LET112_tree=null;
        AstNode IDENT113_tree=null;
        AstNode char_literal114_tree=null;
        AstNode ASSIGN116_tree=null;
        AstNode VAR118_tree=null;
        AstNode char_literal120_tree=null;
        AstNode ASSIGN122_tree=null;
        AstNode char_literal125_tree=null;
        AstNode char_literal127_tree=null;
        AstNode ASSIGN129_tree=null;
        AstNode FOR132_tree=null;
        AstNode VAR133_tree=null;
        AstNode IDENT134_tree=null;
        AstNode IN135_tree=null;
        AstNode string_literal137_tree=null;
        AstNode PRINT140_tree=null;
        AstNode char_literal141_tree=null;
        AstNode STRINGVAL142_tree=null;
        AstNode char_literal143_tree=null;
        AstNode REPEATE145_tree=null;
        AstNode WHILE147_tree=null;
        AstNode FUNC149_tree=null;
        AstNode IDENT150_tree=null;
        AstNode char_literal151_tree=null;
        AstNode char_literal153_tree=null;
        AstNode string_literal154_tree=null;
        AstNode RETURN157_tree=null;
        AstNode SWITCH159_tree=null;
        AstNode IDENT160_tree=null;
        AstNode char_literal161_tree=null;
        AstNode DEFAULT163_tree=null;
        AstNode char_literal164_tree=null;
        AstNode char_literal166_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_VAR = new RewriteRuleTokenStream(adaptor,"token VAR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_SWITCH = new RewriteRuleTokenStream(adaptor,"token SWITCH");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_DEFAULT = new RewriteRuleTokenStream(adaptor,"token DEFAULT");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleTokenStream stream_REPEATE = new RewriteRuleTokenStream(adaptor,"token REPEATE");
        RewriteRuleSubtreeStream stream_returnValue = new RewriteRuleSubtreeStream(adaptor,"rule returnValue");
        RewriteRuleSubtreeStream stream_exprList = new RewriteRuleSubtreeStream(adaptor,"rule exprList");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        RewriteRuleSubtreeStream stream_term = new RewriteRuleSubtreeStream(adaptor,"rule term");
        RewriteRuleSubtreeStream stream_arrayValue = new RewriteRuleSubtreeStream(adaptor,"rule arrayValue");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_swcase = new RewriteRuleSubtreeStream(adaptor,"rule swcase");
        RewriteRuleSubtreeStream stream_idar = new RewriteRuleSubtreeStream(adaptor,"rule idar");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:174:5: ( BEGIN exprList END -> ^( BLOCK ( exprList )? ) | IDENT allassign term | IF term expr ( ELSE expr )? | WHILE term expr | FOR ( ( VAR )? IDENT ASSIGN term ';' ) compare ';' ( groupExpr ';' ) expr | LET IDENT ( ':' type )? ( ASSIGN returnValue )? | VAR idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? ( ',' idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? )* -> ^( VAR ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ( ^( ARRAY arrayValue ) )? ) )* ) | FOR ( VAR )? IDENT IN term '...' term expr | PRINT '(' STRINGVAL ')' | groupExpr | REPEATE expr WHILE term -> ^( REPEATE term expr ) | FUNC IDENT '(' ( func_params )? ')' ( '->' type )? expr | RETURN returnValue | SWITCH IDENT '{' ( swcase )? ( DEFAULT ':' expr )? '}' -> ^( SWITCH IDENT ( swcase )? ( DEFAULT expr )? ) )
            int alt39 = 14;
            alt39 = dfa39.Predict(input);
            switch (alt39) 
            {
                case 1 :
                    // MathExpr.g:175:3: BEGIN exprList END
                    {
                    	BEGIN87=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_expr1503); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BEGIN.Add(BEGIN87);

                    	PushFollow(FOLLOW_exprList_in_expr1505);
                    	exprList88 = exprList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exprList.Add(exprList88.Tree);
                    	END89=(IToken)Match(input,END,FOLLOW_END_in_expr1507); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_END.Add(END89);



                    	// AST REWRITE
                    	// elements:          exprList
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 175:22: -> ^( BLOCK ( exprList )? )
                    	{
                    	    // MathExpr.g:175:25: ^( BLOCK ( exprList )? )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(BLOCK, "BLOCK"), root_1);

                    	    // MathExpr.g:175:33: ( exprList )?
                    	    if ( stream_exprList.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_exprList.NextTree());

                    	    }
                    	    stream_exprList.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MathExpr.g:176:3: IDENT allassign term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IDENT90=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1520); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT90_tree = (AstNode)adaptor.Create(IDENT90);
                    		adaptor.AddChild(root_0, IDENT90_tree);
                    	}
                    	PushFollow(FOLLOW_allassign_in_expr1522);
                    	allassign91 = allassign();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot(allassign91.Tree, root_0);
                    	PushFollow(FOLLOW_term_in_expr1525);
                    	term92 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term92.Tree);

                    }
                    break;
                case 3 :
                    // MathExpr.g:177:3: IF term expr ( ELSE expr )?
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IF93=(IToken)Match(input,IF,FOLLOW_IF_in_expr1529); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF93_tree = (AstNode)adaptor.Create(IF93);
                    		root_0 = (AstNode)adaptor.BecomeRoot(IF93_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr1532);
                    	term94 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term94.Tree);
                    	PushFollow(FOLLOW_expr_in_expr1534);
                    	expr95 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr95.Tree);
                    	// MathExpr.g:177:17: ( ELSE expr )?
                    	int alt23 = 2;
                    	int LA23_0 = input.LA(1);

                    	if ( (LA23_0 == ELSE) )
                    	{
                    	    int LA23_1 = input.LA(2);

                    	    if ( (synpred47_MathExpr()) )
                    	    {
                    	        alt23 = 1;
                    	    }
                    	}
                    	switch (alt23) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:177:18: ELSE expr
                    	        {
                    	        	ELSE96=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr1537); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr1540);
                    	        	expr97 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr97.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // MathExpr.g:178:3: WHILE term expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	WHILE98=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr1546); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE98_tree = (AstNode)adaptor.Create(WHILE98);
                    		root_0 = (AstNode)adaptor.BecomeRoot(WHILE98_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr1549);
                    	term99 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term99.Tree);
                    	PushFollow(FOLLOW_expr_in_expr1552);
                    	expr100 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr100.Tree);

                    }
                    break;
                case 5 :
                    // MathExpr.g:179:3: FOR ( ( VAR )? IDENT ASSIGN term ';' ) compare ';' ( groupExpr ';' ) expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FOR101=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr1556); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR101_tree = (AstNode)adaptor.Create(FOR101);
                    		root_0 = (AstNode)adaptor.BecomeRoot(FOR101_tree, root_0);
                    	}
                    	// MathExpr.g:179:8: ( ( VAR )? IDENT ASSIGN term ';' )
                    	// MathExpr.g:179:9: ( VAR )? IDENT ASSIGN term ';'
                    	{
                    		// MathExpr.g:179:12: ( VAR )?
                    		int alt24 = 2;
                    		int LA24_0 = input.LA(1);

                    		if ( (LA24_0 == VAR) )
                    		{
                    		    alt24 = 1;
                    		}
                    		switch (alt24) 
                    		{
                    		    case 1 :
                    		        // MathExpr.g:0:0: VAR
                    		        {
                    		        	VAR102=(IToken)Match(input,VAR,FOLLOW_VAR_in_expr1560); if (state.failed) return retval;

                    		        }
                    		        break;

                    		}

                    		IDENT103=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1564); if (state.failed) return retval;
                    		if ( state.backtracking == 0 )
                    		{IDENT103_tree = (AstNode)adaptor.Create(IDENT103);
                    			adaptor.AddChild(root_0, IDENT103_tree);
                    		}
                    		ASSIGN104=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1566); if (state.failed) return retval;
                    		PushFollow(FOLLOW_term_in_expr1569);
                    		term105 = term();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term105.Tree);
                    		char_literal106=(IToken)Match(input,69,FOLLOW_69_in_expr1571); if (state.failed) return retval;

                    	}

                    	PushFollow(FOLLOW_compare_in_expr1575);
                    	compare107 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare107.Tree);
                    	char_literal108=(IToken)Match(input,69,FOLLOW_69_in_expr1577); if (state.failed) return retval;
                    	// MathExpr.g:179:53: ( groupExpr ';' )
                    	// MathExpr.g:179:55: groupExpr ';'
                    	{
                    		PushFollow(FOLLOW_groupExpr_in_expr1582);
                    		groupExpr109 = groupExpr();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr109.Tree);
                    		char_literal110=(IToken)Match(input,69,FOLLOW_69_in_expr1584); if (state.failed) return retval;

                    	}

                    	PushFollow(FOLLOW_expr_in_expr1588);
                    	expr111 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr111.Tree);

                    }
                    break;
                case 6 :
                    // MathExpr.g:180:3: LET IDENT ( ':' type )? ( ASSIGN returnValue )?
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	LET112=(IToken)Match(input,LET,FOLLOW_LET_in_expr1592); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LET112_tree = (AstNode)adaptor.Create(LET112);
                    		root_0 = (AstNode)adaptor.BecomeRoot(LET112_tree, root_0);
                    	}
                    	IDENT113=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1595); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT113_tree = (AstNode)adaptor.Create(IDENT113);
                    		adaptor.AddChild(root_0, IDENT113_tree);
                    	}
                    	// MathExpr.g:180:14: ( ':' type )?
                    	int alt25 = 2;
                    	int LA25_0 = input.LA(1);

                    	if ( (LA25_0 == 66) )
                    	{
                    	    alt25 = 1;
                    	}
                    	switch (alt25) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:180:15: ':' type
                    	        {
                    	        	char_literal114=(IToken)Match(input,66,FOLLOW_66_in_expr1598); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_type_in_expr1601);
                    	        	type115 = type();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type115.Tree);

                    	        }
                    	        break;

                    	}

                    	// MathExpr.g:180:27: ( ASSIGN returnValue )?
                    	int alt26 = 2;
                    	int LA26_0 = input.LA(1);

                    	if ( (LA26_0 == ASSIGN) )
                    	{
                    	    alt26 = 1;
                    	}
                    	switch (alt26) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:180:28: ASSIGN returnValue
                    	        {
                    	        	ASSIGN116=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1606); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_returnValue_in_expr1609);
                    	        	returnValue117 = returnValue();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnValue117.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 7 :
                    // MathExpr.g:181:3: VAR idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? ( ',' idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? )*
                    {
                    	VAR118=(IToken)Match(input,VAR,FOLLOW_VAR_in_expr1615); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_VAR.Add(VAR118);

                    	PushFollow(FOLLOW_idar_in_expr1617);
                    	idar119 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idar.Add(idar119.Tree);
                    	// MathExpr.g:181:12: ( ':' type )?
                    	int alt27 = 2;
                    	int LA27_0 = input.LA(1);

                    	if ( (LA27_0 == 66) )
                    	{
                    	    alt27 = 1;
                    	}
                    	switch (alt27) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:181:13: ':' type
                    	        {
                    	        	char_literal120=(IToken)Match(input,66,FOLLOW_66_in_expr1620); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_66.Add(char_literal120);

                    	        	PushFollow(FOLLOW_type_in_expr1622);
                    	        	type121 = type();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_type.Add(type121.Tree);

                    	        }
                    	        break;

                    	}

                    	// MathExpr.g:181:24: ( ASSIGN ( returnValue | arrayValue ) )?
                    	int alt29 = 2;
                    	int LA29_0 = input.LA(1);

                    	if ( (LA29_0 == ASSIGN) )
                    	{
                    	    alt29 = 1;
                    	}
                    	switch (alt29) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:181:25: ASSIGN ( returnValue | arrayValue )
                    	        {
                    	        	ASSIGN122=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1627); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN122);

                    	        	// MathExpr.g:181:32: ( returnValue | arrayValue )
                    	        	int alt28 = 2;
                    	        	int LA28_0 = input.LA(1);

                    	        	if ( (LA28_0 == NOT || (LA28_0 >= NUMBER && LA28_0 <= IDENT) || (LA28_0 >= INCR && LA28_0 <= DECR) || LA28_0 == 67) )
                    	        	{
                    	        	    alt28 = 1;
                    	        	}
                    	        	else if ( (LA28_0 == 63) )
                    	        	{
                    	        	    alt28 = 2;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	        	    NoViableAltException nvae_d28s0 =
                    	        	        new NoViableAltException("", 28, 0, input);

                    	        	    throw nvae_d28s0;
                    	        	}
                    	        	switch (alt28) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MathExpr.g:181:34: returnValue
                    	        	        {
                    	        	        	PushFollow(FOLLOW_returnValue_in_expr1631);
                    	        	        	returnValue123 = returnValue();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return retval;
                    	        	        	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue123.Tree);

                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // MathExpr.g:181:48: arrayValue
                    	        	        {
                    	        	        	PushFollow(FOLLOW_arrayValue_in_expr1635);
                    	        	        	arrayValue124 = arrayValue();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return retval;
                    	        	        	if ( (state.backtracking==0) ) stream_arrayValue.Add(arrayValue124.Tree);

                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;

                    	}

                    	// MathExpr.g:181:62: ( ',' idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? )*
                    	do 
                    	{
                    	    int alt33 = 2;
                    	    int LA33_0 = input.LA(1);

                    	    if ( (LA33_0 == 65) )
                    	    {
                    	        alt33 = 1;
                    	    }


                    	    switch (alt33) 
                    		{
                    			case 1 :
                    			    // MathExpr.g:181:63: ',' idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )?
                    			    {
                    			    	char_literal125=(IToken)Match(input,65,FOLLOW_65_in_expr1641); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_65.Add(char_literal125);

                    			    	PushFollow(FOLLOW_idar_in_expr1643);
                    			    	idar126 = idar();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_idar.Add(idar126.Tree);
                    			    	// MathExpr.g:181:72: ( ':' type )?
                    			    	int alt30 = 2;
                    			    	int LA30_0 = input.LA(1);

                    			    	if ( (LA30_0 == 66) )
                    			    	{
                    			    	    alt30 = 1;
                    			    	}
                    			    	switch (alt30) 
                    			    	{
                    			    	    case 1 :
                    			    	        // MathExpr.g:181:73: ':' type
                    			    	        {
                    			    	        	char_literal127=(IToken)Match(input,66,FOLLOW_66_in_expr1646); if (state.failed) return retval; 
                    			    	        	if ( (state.backtracking==0) ) stream_66.Add(char_literal127);

                    			    	        	PushFollow(FOLLOW_type_in_expr1648);
                    			    	        	type128 = type();
                    			    	        	state.followingStackPointer--;
                    			    	        	if (state.failed) return retval;
                    			    	        	if ( (state.backtracking==0) ) stream_type.Add(type128.Tree);

                    			    	        }
                    			    	        break;

                    			    	}

                    			    	// MathExpr.g:181:84: ( ASSIGN ( returnValue | arrayValue ) )?
                    			    	int alt32 = 2;
                    			    	int LA32_0 = input.LA(1);

                    			    	if ( (LA32_0 == ASSIGN) )
                    			    	{
                    			    	    alt32 = 1;
                    			    	}
                    			    	switch (alt32) 
                    			    	{
                    			    	    case 1 :
                    			    	        // MathExpr.g:181:85: ASSIGN ( returnValue | arrayValue )
                    			    	        {
                    			    	        	ASSIGN129=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1653); if (state.failed) return retval; 
                    			    	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN129);

                    			    	        	// MathExpr.g:181:92: ( returnValue | arrayValue )
                    			    	        	int alt31 = 2;
                    			    	        	int LA31_0 = input.LA(1);

                    			    	        	if ( (LA31_0 == NOT || (LA31_0 >= NUMBER && LA31_0 <= IDENT) || (LA31_0 >= INCR && LA31_0 <= DECR) || LA31_0 == 67) )
                    			    	        	{
                    			    	        	    alt31 = 1;
                    			    	        	}
                    			    	        	else if ( (LA31_0 == 63) )
                    			    	        	{
                    			    	        	    alt31 = 2;
                    			    	        	}
                    			    	        	else 
                    			    	        	{
                    			    	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			    	        	    NoViableAltException nvae_d31s0 =
                    			    	        	        new NoViableAltException("", 31, 0, input);

                    			    	        	    throw nvae_d31s0;
                    			    	        	}
                    			    	        	switch (alt31) 
                    			    	        	{
                    			    	        	    case 1 :
                    			    	        	        // MathExpr.g:181:94: returnValue
                    			    	        	        {
                    			    	        	        	PushFollow(FOLLOW_returnValue_in_expr1657);
                    			    	        	        	returnValue130 = returnValue();
                    			    	        	        	state.followingStackPointer--;
                    			    	        	        	if (state.failed) return retval;
                    			    	        	        	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue130.Tree);

                    			    	        	        }
                    			    	        	        break;
                    			    	        	    case 2 :
                    			    	        	        // MathExpr.g:181:108: arrayValue
                    			    	        	        {
                    			    	        	        	PushFollow(FOLLOW_arrayValue_in_expr1661);
                    			    	        	        	arrayValue131 = arrayValue();
                    			    	        	        	state.followingStackPointer--;
                    			    	        	        	if (state.failed) return retval;
                    			    	        	        	if ( (state.backtracking==0) ) stream_arrayValue.Add(arrayValue131.Tree);

                    			    	        	        }
                    			    	        	        break;

                    			    	        	}


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop33;
                    	    }
                    	} while (true);

                    	loop33:
                    		;	// Stops C# compiler whining that label 'loop33' has no statements



                    	// AST REWRITE
                    	// elements:          idar, returnValue, VAR, type, arrayValue, ASSIGN
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 181:124: -> ^( VAR ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ( ^( ARRAY arrayValue ) )? ) )* )
                    	{
                    	    // MathExpr.g:181:127: ^( VAR ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ( ^( ARRAY arrayValue ) )? ) )* )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

                    	    // MathExpr.g:181:133: ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ( ^( ARRAY arrayValue ) )? ) )*
                    	    while ( stream_idar.HasNext() )
                    	    {
                    	        // MathExpr.g:181:133: ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ( ^( ARRAY arrayValue ) )? )
                    	        {
                    	        AstNode root_2 = (AstNode)adaptor.GetNilNode();
                    	        root_2 = (AstNode)adaptor.BecomeRoot(stream_idar.NextNode(), root_2);

                    	        // MathExpr.g:181:140: ^( TYPE ( type )? )
                    	        {
                    	        AstNode root_3 = (AstNode)adaptor.GetNilNode();
                    	        root_3 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(TYPE, "TYPE"), root_3);

                    	        // MathExpr.g:181:147: ( type )?
                    	        if ( stream_type.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_3, stream_type.NextTree());

                    	        }
                    	        stream_type.Reset();

                    	        adaptor.AddChild(root_2, root_3);
                    	        }
                    	        // MathExpr.g:181:154: ( ^( ASSIGN returnValue ) )?
                    	        if ( stream_returnValue.HasNext() || stream_ASSIGN.HasNext() )
                    	        {
                    	            // MathExpr.g:181:154: ^( ASSIGN returnValue )
                    	            {
                    	            AstNode root_3 = (AstNode)adaptor.GetNilNode();
                    	            root_3 = (AstNode)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_3);

                    	            adaptor.AddChild(root_3, stream_returnValue.NextTree());

                    	            adaptor.AddChild(root_2, root_3);
                    	            }

                    	        }
                    	        stream_returnValue.Reset();
                    	        stream_ASSIGN.Reset();
                    	        // MathExpr.g:181:178: ( ^( ARRAY arrayValue ) )?
                    	        if ( stream_arrayValue.HasNext() )
                    	        {
                    	            // MathExpr.g:181:178: ^( ARRAY arrayValue )
                    	            {
                    	            AstNode root_3 = (AstNode)adaptor.GetNilNode();
                    	            root_3 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(ARRAY, "ARRAY"), root_3);

                    	            adaptor.AddChild(root_3, stream_arrayValue.NextTree());

                    	            adaptor.AddChild(root_2, root_3);
                    	            }

                    	        }
                    	        stream_arrayValue.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_idar.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 8 :
                    // MathExpr.g:182:3: FOR ( VAR )? IDENT IN term '...' term expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FOR132=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr1703); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR132_tree = (AstNode)adaptor.Create(FOR132);
                    		root_0 = (AstNode)adaptor.BecomeRoot(FOR132_tree, root_0);
                    	}
                    	// MathExpr.g:182:11: ( VAR )?
                    	int alt34 = 2;
                    	int LA34_0 = input.LA(1);

                    	if ( (LA34_0 == VAR) )
                    	{
                    	    alt34 = 1;
                    	}
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:0:0: VAR
                    	        {
                    	        	VAR133=(IToken)Match(input,VAR,FOLLOW_VAR_in_expr1706); if (state.failed) return retval;

                    	        }
                    	        break;

                    	}

                    	IDENT134=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1710); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT134_tree = (AstNode)adaptor.Create(IDENT134);
                    		adaptor.AddChild(root_0, IDENT134_tree);
                    	}
                    	IN135=(IToken)Match(input,IN,FOLLOW_IN_in_expr1712); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_expr1715);
                    	term136 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term136.Tree);
                    	string_literal137=(IToken)Match(input,70,FOLLOW_70_in_expr1717); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_expr1720);
                    	term138 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term138.Tree);
                    	PushFollow(FOLLOW_expr_in_expr1722);
                    	expr139 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr139.Tree);

                    }
                    break;
                case 9 :
                    // MathExpr.g:183:3: PRINT '(' STRINGVAL ')'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PRINT140=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_expr1726); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PRINT140_tree = (AstNode)adaptor.Create(PRINT140);
                    		adaptor.AddChild(root_0, PRINT140_tree);
                    	}
                    	char_literal141=(IToken)Match(input,67,FOLLOW_67_in_expr1728); if (state.failed) return retval;
                    	STRINGVAL142=(IToken)Match(input,STRINGVAL,FOLLOW_STRINGVAL_in_expr1731); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRINGVAL142_tree = (AstNode)adaptor.Create(STRINGVAL142);
                    		adaptor.AddChild(root_0, STRINGVAL142_tree);
                    	}
                    	char_literal143=(IToken)Match(input,68,FOLLOW_68_in_expr1733); if (state.failed) return retval;

                    }
                    break;
                case 10 :
                    // MathExpr.g:184:3: groupExpr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_groupExpr_in_expr1738);
                    	groupExpr144 = groupExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr144.Tree);

                    }
                    break;
                case 11 :
                    // MathExpr.g:185:3: REPEATE expr WHILE term
                    {
                    	REPEATE145=(IToken)Match(input,REPEATE,FOLLOW_REPEATE_in_expr1742); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_REPEATE.Add(REPEATE145);

                    	PushFollow(FOLLOW_expr_in_expr1744);
                    	expr146 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr146.Tree);
                    	WHILE147=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr1746); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE147);

                    	PushFollow(FOLLOW_term_in_expr1748);
                    	term148 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_term.Add(term148.Tree);


                    	// AST REWRITE
                    	// elements:          expr, term, REPEATE
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 185:27: -> ^( REPEATE term expr )
                    	{
                    	    // MathExpr.g:185:30: ^( REPEATE term expr )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_REPEATE.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_term.NextTree());
                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 12 :
                    // MathExpr.g:186:3: FUNC IDENT '(' ( func_params )? ')' ( '->' type )? expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FUNC149=(IToken)Match(input,FUNC,FOLLOW_FUNC_in_expr1762); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FUNC149_tree = (AstNode)adaptor.Create(FUNC149);
                    		root_0 = (AstNode)adaptor.BecomeRoot(FUNC149_tree, root_0);
                    	}
                    	IDENT150=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1765); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT150_tree = (AstNode)adaptor.Create(IDENT150);
                    		adaptor.AddChild(root_0, IDENT150_tree);
                    	}
                    	char_literal151=(IToken)Match(input,67,FOLLOW_67_in_expr1767); if (state.failed) return retval;
                    	// MathExpr.g:186:20: ( func_params )?
                    	int alt35 = 2;
                    	int LA35_0 = input.LA(1);

                    	if ( (LA35_0 == IDENT) )
                    	{
                    	    alt35 = 1;
                    	}
                    	switch (alt35) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:0:0: func_params
                    	        {
                    	        	PushFollow(FOLLOW_func_params_in_expr1770);
                    	        	func_params152 = func_params();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_params152.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal153=(IToken)Match(input,68,FOLLOW_68_in_expr1773); if (state.failed) return retval;
                    	// MathExpr.g:186:38: ( '->' type )?
                    	int alt36 = 2;
                    	int LA36_0 = input.LA(1);

                    	if ( (LA36_0 == 71) )
                    	{
                    	    alt36 = 1;
                    	}
                    	switch (alt36) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:186:39: '->' type
                    	        {
                    	        	string_literal154=(IToken)Match(input,71,FOLLOW_71_in_expr1777); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_type_in_expr1780);
                    	        	type155 = type();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type155.Tree);

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_expr_in_expr1784);
                    	expr156 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr156.Tree);

                    }
                    break;
                case 13 :
                    // MathExpr.g:187:3: RETURN returnValue
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	RETURN157=(IToken)Match(input,RETURN,FOLLOW_RETURN_in_expr1788); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RETURN157_tree = (AstNode)adaptor.Create(RETURN157);
                    		root_0 = (AstNode)adaptor.BecomeRoot(RETURN157_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_returnValue_in_expr1791);
                    	returnValue158 = returnValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnValue158.Tree);

                    }
                    break;
                case 14 :
                    // MathExpr.g:188:3: SWITCH IDENT '{' ( swcase )? ( DEFAULT ':' expr )? '}'
                    {
                    	SWITCH159=(IToken)Match(input,SWITCH,FOLLOW_SWITCH_in_expr1795); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_SWITCH.Add(SWITCH159);

                    	IDENT160=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1797); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT160);

                    	char_literal161=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_expr1799); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BEGIN.Add(char_literal161);

                    	// MathExpr.g:188:20: ( swcase )?
                    	int alt37 = 2;
                    	switch ( input.LA(1) ) 
                    	{
                    	    case CASE:
                    	    	{
                    	        alt37 = 1;
                    	        }
                    	        break;
                    	    case DEFAULT:
                    	    	{
                    	        int LA37_2 = input.LA(2);

                    	        if ( (synpred72_MathExpr()) )
                    	        {
                    	            alt37 = 1;
                    	        }
                    	        }
                    	        break;
                    	    case END:
                    	    	{
                    	        int LA37_3 = input.LA(2);

                    	        if ( (synpred72_MathExpr()) )
                    	        {
                    	            alt37 = 1;
                    	        }
                    	        }
                    	        break;
                    	}

                    	switch (alt37) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:0:0: swcase
                    	        {
                    	        	PushFollow(FOLLOW_swcase_in_expr1801);
                    	        	swcase162 = swcase();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_swcase.Add(swcase162.Tree);

                    	        }
                    	        break;

                    	}

                    	// MathExpr.g:188:28: ( DEFAULT ':' expr )?
                    	int alt38 = 2;
                    	int LA38_0 = input.LA(1);

                    	if ( (LA38_0 == DEFAULT) )
                    	{
                    	    alt38 = 1;
                    	}
                    	switch (alt38) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:188:29: DEFAULT ':' expr
                    	        {
                    	        	DEFAULT163=(IToken)Match(input,DEFAULT,FOLLOW_DEFAULT_in_expr1805); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_DEFAULT.Add(DEFAULT163);

                    	        	char_literal164=(IToken)Match(input,66,FOLLOW_66_in_expr1807); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_66.Add(char_literal164);

                    	        	PushFollow(FOLLOW_expr_in_expr1809);
                    	        	expr165 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_expr.Add(expr165.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal166=(IToken)Match(input,END,FOLLOW_END_in_expr1813); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_END.Add(char_literal166);



                    	// AST REWRITE
                    	// elements:          expr, SWITCH, swcase, IDENT, DEFAULT
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 188:52: -> ^( SWITCH IDENT ( swcase )? ( DEFAULT expr )? )
                    	{
                    	    // MathExpr.g:188:55: ^( SWITCH IDENT ( swcase )? ( DEFAULT expr )? )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_SWITCH.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
                    	    // MathExpr.g:188:71: ( swcase )?
                    	    if ( stream_swcase.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_swcase.NextTree());

                    	    }
                    	    stream_swcase.Reset();
                    	    // MathExpr.g:188:79: ( DEFAULT expr )?
                    	    if ( stream_expr.HasNext() || stream_DEFAULT.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_DEFAULT.NextNode());
                    	        adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    }
                    	    stream_expr.Reset();
                    	    stream_DEFAULT.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, expr_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class exprList_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "exprList"
    // MathExpr.g:191:1: exprList : ( expr ( ( ';' )? exprList | ( ';' )* ) )? ;
    public MathExprParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MathExprParser.exprList_return retval = new MathExprParser.exprList_return();
        retval.Start = input.LT(1);
        int exprList_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal168 = null;
        IToken char_literal170 = null;
        MathExprParser.expr_return expr167 = default(MathExprParser.expr_return);

        MathExprParser.exprList_return exprList169 = default(MathExprParser.exprList_return);


        AstNode char_literal168_tree=null;
        AstNode char_literal170_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:191:9: ( ( expr ( ( ';' )? exprList | ( ';' )* ) )? )
            // MathExpr.g:191:11: ( expr ( ( ';' )? exprList | ( ';' )* ) )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	// MathExpr.g:191:11: ( expr ( ( ';' )? exprList | ( ';' )* ) )?
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( (LA43_0 == PRINT || LA43_0 == BEGIN || LA43_0 == IF || (LA43_0 >= WHILE && LA43_0 <= FOR) || LA43_0 == LET || LA43_0 == REPEATE || LA43_0 == VAR || (LA43_0 >= FUNC && LA43_0 <= SWITCH) || LA43_0 == IDENT || (LA43_0 >= INCR && LA43_0 <= DECR)) )
            	{
            	    alt43 = 1;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // MathExpr.g:191:12: expr ( ( ';' )? exprList | ( ';' )* )
            	        {
            	        	PushFollow(FOLLOW_expr_in_exprList1842);
            	        	expr167 = expr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr167.Tree);
            	        	// MathExpr.g:191:17: ( ( ';' )? exprList | ( ';' )* )
            	        	int alt42 = 2;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case 69:
            	        		{
            	        	    int LA42_1 = input.LA(2);

            	        	    if ( (synpred75_MathExpr()) )
            	        	    {
            	        	        alt42 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt42 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        NoViableAltException nvae_d42s1 =
            	        	            new NoViableAltException("", 42, 1, input);

            	        	        throw nvae_d42s1;
            	        	    }
            	        	    }
            	        	    break;
            	        	case PRINT:
            	        	case BEGIN:
            	        	case IF:
            	        	case WHILE:
            	        	case FOR:
            	        	case LET:
            	        	case REPEATE:
            	        	case VAR:
            	        	case FUNC:
            	        	case RETURN:
            	        	case SWITCH:
            	        	case IDENT:
            	        	case INCR:
            	        	case DECR:
            	        		{
            	        	    alt42 = 1;
            	        	    }
            	        	    break;
            	        	case END:
            	        		{
            	        	    int LA42_3 = input.LA(2);

            	        	    if ( (synpred75_MathExpr()) )
            	        	    {
            	        	        alt42 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt42 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        NoViableAltException nvae_d42s3 =
            	        	            new NoViableAltException("", 42, 3, input);

            	        	        throw nvae_d42s3;
            	        	    }
            	        	    }
            	        	    break;
            	        	case EOF:
            	        		{
            	        	    int LA42_4 = input.LA(2);

            	        	    if ( (synpred75_MathExpr()) )
            	        	    {
            	        	        alt42 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt42 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        NoViableAltException nvae_d42s4 =
            	        	            new NoViableAltException("", 42, 4, input);

            	        	        throw nvae_d42s4;
            	        	    }
            	        	    }
            	        	    break;
            	        		default:
            	        		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        		    NoViableAltException nvae_d42s0 =
            	        		        new NoViableAltException("", 42, 0, input);

            	        		    throw nvae_d42s0;
            	        	}

            	        	switch (alt42) 
            	        	{
            	        	    case 1 :
            	        	        // MathExpr.g:191:18: ( ';' )? exprList
            	        	        {
            	        	        	// MathExpr.g:191:18: ( ';' )?
            	        	        	int alt40 = 2;
            	        	        	int LA40_0 = input.LA(1);

            	        	        	if ( (LA40_0 == 69) )
            	        	        	{
            	        	        	    alt40 = 1;
            	        	        	}
            	        	        	switch (alt40) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // MathExpr.g:191:19: ';'
            	        	        	        {
            	        	        	        	char_literal168=(IToken)Match(input,69,FOLLOW_69_in_exprList1846); if (state.failed) return retval;

            	        	        	        }
            	        	        	        break;

            	        	        	}

            	        	        	PushFollow(FOLLOW_exprList_in_exprList1852);
            	        	        	exprList169 = exprList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList169.Tree);

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MathExpr.g:191:38: ( ';' )*
            	        	        {
            	        	        	// MathExpr.g:191:38: ( ';' )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt41 = 2;
            	        	        	    int LA41_0 = input.LA(1);

            	        	        	    if ( (LA41_0 == 69) )
            	        	        	    {
            	        	        	        alt41 = 1;
            	        	        	    }


            	        	        	    switch (alt41) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // MathExpr.g:191:39: ';'
            	        	        			    {
            	        	        			    	char_literal170=(IToken)Match(input,69,FOLLOW_69_in_exprList1857); if (state.failed) return retval;

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop41;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop41:
            	        	        		;	// Stops C# compiler whining that label 'loop41' has no statements


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, exprList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "exprList"

    public class program_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "program"
    // MathExpr.g:194:1: program : exprList ;
    public MathExprParser.program_return program() // throws RecognitionException [1]
    {   
        MathExprParser.program_return retval = new MathExprParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.exprList_return exprList171 = default(MathExprParser.exprList_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:194:8: ( exprList )
            // MathExpr.g:194:11: exprList
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_exprList_in_program1872);
            	exprList171 = exprList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList171.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, program_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "program"

    public class execute_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "execute"
    // MathExpr.g:198:8: public execute : program -> ^( PROGRAM program ) ;
    public MathExprParser.execute_return execute() // throws RecognitionException [1]
    {   
        MathExprParser.execute_return retval = new MathExprParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.program_return program172 = default(MathExprParser.program_return);


        RewriteRuleSubtreeStream stream_program = new RewriteRuleSubtreeStream(adaptor,"rule program");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:198:15: ( program -> ^( PROGRAM program ) )
            // MathExpr.g:199:5: program
            {
            	PushFollow(FOLLOW_program_in_execute1888);
            	program172 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program.Add(program172.Tree);


            	// AST REWRITE
            	// elements:          program
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 199:13: -> ^( PROGRAM program )
            	{
            	    // MathExpr.g:199:16: ^( PROGRAM program )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

            	    adaptor.AddChild(root_1, stream_program.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, execute_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "execute"

    // $ANTLR start "synpred10_MathExpr"
    public void synpred10_MathExpr_fragment() {
        // MathExpr.g:117:14: ( term )
        // MathExpr.g:117:14: term
        {
        	PushFollow(FOLLOW_term_in_synpred10_MathExpr1047);
        	term();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_MathExpr"

    // $ANTLR start "synpred11_MathExpr"
    public void synpred11_MathExpr_fragment() {
        // MathExpr.g:117:21: ( value )
        // MathExpr.g:117:21: value
        {
        	PushFollow(FOLLOW_value_in_synpred11_MathExpr1051);
        	value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_MathExpr"

    // $ANTLR start "synpred16_MathExpr"
    public void synpred16_MathExpr_fragment() {
        // MathExpr.g:121:23: ( idar INCR )
        // MathExpr.g:121:23: idar INCR
        {
        	PushFollow(FOLLOW_idar_in_synpred16_MathExpr1119);
        	idar();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,INCR,FOLLOW_INCR_in_synpred16_MathExpr1121); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_MathExpr"

    // $ANTLR start "synpred27_MathExpr"
    public void synpred27_MathExpr_fragment() {
        // MathExpr.g:140:2: ( groupExpr )
        // MathExpr.g:140:2: groupExpr
        {
        	PushFollow(FOLLOW_groupExpr_in_synpred27_MathExpr1298);
        	groupExpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred27_MathExpr"

    // $ANTLR start "synpred47_MathExpr"
    public void synpred47_MathExpr_fragment() {
        // MathExpr.g:177:18: ( ELSE expr )
        // MathExpr.g:177:18: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred47_MathExpr1537); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred47_MathExpr1540);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred47_MathExpr"

    // $ANTLR start "synpred72_MathExpr"
    public void synpred72_MathExpr_fragment() {
        // MathExpr.g:188:20: ( swcase )
        // MathExpr.g:188:20: swcase
        {
        	PushFollow(FOLLOW_swcase_in_synpred72_MathExpr1801);
        	swcase();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred72_MathExpr"

    // $ANTLR start "synpred75_MathExpr"
    public void synpred75_MathExpr_fragment() {
        // MathExpr.g:191:18: ( ( ';' )? exprList )
        // MathExpr.g:191:18: ( ';' )? exprList
        {
        	// MathExpr.g:191:18: ( ';' )?
        	int alt65 = 2;
        	int LA65_0 = input.LA(1);

        	if ( (LA65_0 == 69) )
        	{
        	    alt65 = 1;
        	}
        	switch (alt65) 
        	{
        	    case 1 :
        	        // MathExpr.g:191:19: ';'
        	        {
        	        	Match(input,69,FOLLOW_69_in_synpred75_MathExpr1846); if (state.failed) return ;

        	        }
        	        break;

        	}

        	PushFollow(FOLLOW_exprList_in_synpred75_MathExpr1852);
        	exprList();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred75_MathExpr"

    // Delegated rules

   	public bool synpred72_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred72_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred11_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred10_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred16_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred47_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred47_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred27_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred27_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred75_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred75_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA39 dfa39;
	private void InitializeCyclicDFAs()
	{
    	this.dfa39 = new DFA39(this);
	}

    const string DFA39_eotS =
        "\x13\uffff";
    const string DFA39_eofS =
        "\x13\uffff";
    const string DFA39_minS =
        "\x01\x05\x01\uffff\x01\x32\x02\uffff\x01\x1a\x09\uffff\x01\x2d"+
        "\x01\x1b\x02\uffff";
    const string DFA39_maxS =
        "\x01\x34\x01\uffff\x01\x43\x02\uffff\x01\x2d\x09\uffff\x01\x2d"+
        "\x01\x32\x02\uffff";
    const string DFA39_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\uffff\x01\x06"+
        "\x01\x07\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x02"+
        "\x02\uffff\x01\x08\x01\x05";
    const string DFA39_specialS =
        "\x13\uffff}>";
    static readonly string[] DFA39_transitionS = {
            "\x01\x08\x03\uffff\x01\x01\x01\uffff\x01\x03\x01\uffff\x01"+
            "\x04\x01\x05\x04\uffff\x01\x06\x01\uffff\x01\x0a\x04\uffff\x01"+
            "\x07\x04\uffff\x01\x0b\x01\x0c\x01\x0d\x0b\uffff\x01\x02\x05"+
            "\uffff\x02\x09",
            "",
            "\x01\x0e\x02\x09\x04\x0e\x06\uffff\x01\x09\x03\uffff\x01\x09",
            "",
            "",
            "\x01\x0f\x12\uffff\x01\x10",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x10",
            "\x01\x11\x16\uffff\x01\x12",
            "",
            ""
    };

    static readonly short[] DFA39_eot = DFA.UnpackEncodedString(DFA39_eotS);
    static readonly short[] DFA39_eof = DFA.UnpackEncodedString(DFA39_eofS);
    static readonly char[] DFA39_min = DFA.UnpackEncodedStringToUnsignedChars(DFA39_minS);
    static readonly char[] DFA39_max = DFA.UnpackEncodedStringToUnsignedChars(DFA39_maxS);
    static readonly short[] DFA39_accept = DFA.UnpackEncodedString(DFA39_acceptS);
    static readonly short[] DFA39_special = DFA.UnpackEncodedString(DFA39_specialS);
    static readonly short[][] DFA39_transition = DFA.UnpackEncodedStringArray(DFA39_transitionS);

    protected class DFA39 : DFA
    {
        public DFA39(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 39;
            this.eot = DFA39_eot;
            this.eof = DFA39_eof;
            this.min = DFA39_min;
            this.max = DFA39_max;
            this.accept = DFA39_accept;
            this.special = DFA39_special;
            this.transition = DFA39_transition;

        }

        override public string Description
        {
            get { return "174:1: expr : ( BEGIN exprList END -> ^( BLOCK ( exprList )? ) | IDENT allassign term | IF term expr ( ELSE expr )? | WHILE term expr | FOR ( ( VAR )? IDENT ASSIGN term ';' ) compare ';' ( groupExpr ';' ) expr | LET IDENT ( ':' type )? ( ASSIGN returnValue )? | VAR idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? ( ',' idar ( ':' type )? ( ASSIGN ( returnValue | arrayValue ) )? )* -> ^( VAR ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ( ^( ARRAY arrayValue ) )? ) )* ) | FOR ( VAR )? IDENT IN term '...' term expr | PRINT '(' STRINGVAL ')' | groupExpr | REPEATE expr WHILE term -> ^( REPEATE term expr ) | FUNC IDENT '(' ( func_params )? ')' ( '->' type )? expr | RETURN returnValue | SWITCH IDENT '{' ( swcase )? ( DEFAULT ':' expr )? '}' -> ^( SWITCH IDENT ( swcase )? ( DEFAULT expr )? ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_IDENT_in_array775 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_array778 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_add_in_array780 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_array782 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_array_in_idar804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_idar808 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_type990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_type994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_in_type998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_type1002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_in_type1006 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_type1011 = new BitSet(new ulong[]{0x8000000003D00000UL});
    public static readonly BitSet FOLLOW_type_in_type1013 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_type1015 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_value0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_returnValue1047 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_returnValue1051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_returnValue1055 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_arrayValue1062 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_arrayValue1065 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_65_in_arrayValue1068 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_arrayValue1071 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_64_in_arrayValue1075 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_arrayValue1083 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_arrayValue_in_arrayValue1085 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_65_in_arrayValue1088 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_arrayValue_in_arrayValue1090 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_64_in_arrayValue1094 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCR_in_crement1112 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_idar_in_crement1115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_crement1119 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_INCR_in_crement1121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECR_in_crement1126 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_idar_in_crement1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_crement1133 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_DECR_in_crement1135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_allassign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_swcase1169 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_swcase1171 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_65_in_swcase1174 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_swcase1176 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_66_in_swcase1180 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_swcase1182 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_returnValue_in_paramms1210 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_paramms1213 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_paramms1215 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_params1234 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_func_params1236 = new BitSet(new ulong[]{0x8000000003D00000UL});
    public static readonly BitSet FOLLOW_type_in_func_params1238 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_func_params1241 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_params1243 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_func_params1245 = new BitSet(new ulong[]{0x8000000003D00000UL});
    public static readonly BitSet FOLLOW_type_in_func_params1247 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_call1271 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_func_call1273 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_paramms_in_func_call1275 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_func_call1278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupExpr_in_group1298 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupInit_in_group1303 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_groupInit1313 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_term_in_groupInit1316 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_groupInit1318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_groupInit1323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_groupInit1328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_array_in_groupInit1332 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_groupExpr1341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_crement_in_groupExpr1347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_not1358 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_group_in_not1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_not1365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_not_in_mult1373 = new BitSet(new ulong[]{0x0003000000000002UL});
    public static readonly BitSet FOLLOW_set_in_mult1377 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_not_in_mult1388 = new BitSet(new ulong[]{0x0003000000000002UL});
    public static readonly BitSet FOLLOW_mult_in_add1400 = new BitSet(new ulong[]{0x0000C00000000002UL});
    public static readonly BitSet FOLLOW_set_in_add1405 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_mult_in_add1416 = new BitSet(new ulong[]{0x0000C00000000002UL});
    public static readonly BitSet FOLLOW_or_logic_in_term1428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_compare1440 = new BitSet(new ulong[]{0x7E00000000000002UL});
    public static readonly BitSet FOLLOW_set_in_compare1443 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_add_in_compare1458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_compare_in_and_logic1468 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_AND_in_and_logic1471 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_compare_in_and_logic1474 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_and_logic_in_or_logic1483 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_OR_in_or_logic1486 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_and_logic_in_or_logic1489 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_expr1503 = new BitSet(new ulong[]{0x0018200384286E20UL});
    public static readonly BitSet FOLLOW_exprList_in_expr1505 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_END_in_expr1507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1520 = new BitSet(new ulong[]{0x01E4000000000000UL});
    public static readonly BitSet FOLLOW_allassign_in_expr1522 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_term_in_expr1525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr1529 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_term_in_expr1532 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1534 = new BitSet(new ulong[]{0x0000000000001002UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr1537 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr1546 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_term_in_expr1549 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr1556 = new BitSet(new ulong[]{0x0000200004000000UL});
    public static readonly BitSet FOLLOW_VAR_in_expr1560 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1564 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1566 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_term_in_expr1569 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_expr1571 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_compare_in_expr1575 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_expr1577 = new BitSet(new ulong[]{0x0018200000000000UL});
    public static readonly BitSet FOLLOW_groupExpr_in_expr1582 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_expr1584 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LET_in_expr1592 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1595 = new BitSet(new ulong[]{0x0004000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_expr1598 = new BitSet(new ulong[]{0x8000000003D00000UL});
    public static readonly BitSet FOLLOW_type_in_expr1601 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1606 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_expr1609 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_expr1615 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_idar_in_expr1617 = new BitSet(new ulong[]{0x0004000000000002UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_66_in_expr1620 = new BitSet(new ulong[]{0x8000000003D00000UL});
    public static readonly BitSet FOLLOW_type_in_expr1622 = new BitSet(new ulong[]{0x0004000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1627 = new BitSet(new ulong[]{0x80183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_expr1631 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayValue_in_expr1635 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_expr1641 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_idar_in_expr1643 = new BitSet(new ulong[]{0x0004000000000002UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_66_in_expr1646 = new BitSet(new ulong[]{0x8000000003D00000UL});
    public static readonly BitSet FOLLOW_type_in_expr1648 = new BitSet(new ulong[]{0x0004000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1653 = new BitSet(new ulong[]{0x80183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_expr1657 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayValue_in_expr1661 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr1703 = new BitSet(new ulong[]{0x0000200004000000UL});
    public static readonly BitSet FOLLOW_VAR_in_expr1706 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1710 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IN_in_expr1712 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_term_in_expr1715 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_expr1717 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_term_in_expr1720 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1722 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINT_in_expr1726 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_expr1728 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STRINGVAL_in_expr1731 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_expr1733 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupExpr_in_expr1738 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REPEATE_in_expr1742 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1744 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr1746 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_term_in_expr1748 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNC_in_expr1762 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1765 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_expr1767 = new BitSet(new ulong[]{0x0000200000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_func_params_in_expr1770 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_expr1773 = new BitSet(new ulong[]{0x0018200384286A20UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_expr1777 = new BitSet(new ulong[]{0x8000000003D00000UL});
    public static readonly BitSet FOLLOW_type_in_expr1780 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_expr1788 = new BitSet(new ulong[]{0x00183C0000020000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_returnValue_in_expr1791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SWITCH_in_expr1795 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1797 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_BEGIN_in_expr1799 = new BitSet(new ulong[]{0x0000000C00000400UL});
    public static readonly BitSet FOLLOW_swcase_in_expr1801 = new BitSet(new ulong[]{0x0000000800000400UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_expr1805 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_expr1807 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1809 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_END_in_expr1813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_exprList1842 = new BitSet(new ulong[]{0x0018200384286A20UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_exprList1846 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_exprList_in_exprList1852 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_exprList1857 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_exprList_in_program1872 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute1888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_synpred10_MathExpr1047 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_synpred11_MathExpr1051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_synpred16_MathExpr1119 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_INCR_in_synpred16_MathExpr1121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupExpr_in_synpred27_MathExpr1298 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred47_MathExpr1537 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_synpred47_MathExpr1540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_swcase_in_synpred72_MathExpr1801 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_synpred75_MathExpr1846 = new BitSet(new ulong[]{0x0018200384286A20UL});
    public static readonly BitSet FOLLOW_exprList_in_synpred75_MathExpr1852 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}