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
		"TRUE", 
		"FALSE", 
		"SINCR", 
		"EINCR", 
		"SDECR", 
		"EDECR", 
		"CONVERT", 
		"ARRAYPART", 
		"WS", 
		"SL_COMMENT", 
		"ML_COMMENT", 
		"NUMBER", 
		"STRINGVAL", 
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
		"'(count'", 
		"';'", 
		"'...'", 
		"'->'"
    };

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



        public MathExprParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public MathExprParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[108+1];
             
             
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
    // MathExpr.g:96:1: array : IDENT ( '[' add ']' )+ -> ^( ARRAYPART IDENT ( add )* ) ;
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
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_71 = new RewriteRuleTokenStream(adaptor,"token 71");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:96:6: ( IDENT ( '[' add ']' )+ -> ^( ARRAYPART IDENT ( add )* ) )
            // MathExpr.g:96:8: IDENT ( '[' add ']' )+
            {
            	IDENT1=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_array835); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT1);

            	// MathExpr.g:96:14: ( '[' add ']' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 70) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // MathExpr.g:96:15: '[' add ']'
            			    {
            			    	char_literal2=(IToken)Match(input,70,FOLLOW_70_in_array838); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_70.Add(char_literal2);

            			    	PushFollow(FOLLOW_add_in_array840);
            			    	add3 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_add.Add(add3.Tree);
            			    	char_literal4=(IToken)Match(input,71,FOLLOW_71_in_array842); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_71.Add(char_literal4);


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
            	// 96:29: -> ^( ARRAYPART IDENT ( add )* )
            	{
            	    // MathExpr.g:96:32: ^( ARRAYPART IDENT ( add )* )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(ARRAYPART, "ARRAYPART"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // MathExpr.g:96:51: ( add )*
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
    // MathExpr.g:98:1: idar : ( array | IDENT );
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
            // MathExpr.g:98:5: ( array | IDENT )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == IDENT) )
            {
                int LA2_1 = input.LA(2);

                if ( (LA2_1 == 70) )
                {
                    alt2 = 1;
                }
                else if ( (LA2_1 == EOF || LA2_1 == PRINT || (LA2_1 >= BEGIN && LA2_1 <= OR) || LA2_1 == LET || LA2_1 == REPEATE || LA2_1 == VAR || (LA2_1 >= FUNC && LA2_1 <= DEFAULT) || (LA2_1 >= IDENT && LA2_1 <= LT) || (LA2_1 >= 71 && LA2_1 <= 73) || LA2_1 == 75 || (LA2_1 >= 77 && LA2_1 <= 78)) )
                {
                    alt2 = 2;
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
                    // MathExpr.g:98:7: array
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_array_in_idar865);
                    	array5 = array();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array5.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:98:15: IDENT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IDENT6=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_idar869); if (state.failed) return retval;
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
    // MathExpr.g:122:1: type : ( INT | STRING | DOUBLE | FLOAT | BOOL | ( '[' type ']' ) -> ^( ARRAY type ) );
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
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_71 = new RewriteRuleTokenStream(adaptor,"token 71");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:122:5: ( INT | STRING | DOUBLE | FLOAT | BOOL | ( '[' type ']' ) -> ^( ARRAY type ) )
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
            case 70:
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
                    // MathExpr.g:122:7: INT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	INT7=(IToken)Match(input,INT,FOLLOW_INT_in_type1051); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INT7_tree = (AstNode)adaptor.Create(INT7);
                    		adaptor.AddChild(root_0, INT7_tree);
                    	}

                    }
                    break;
                case 2 :
                    // MathExpr.g:122:13: STRING
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	STRING8=(IToken)Match(input,STRING,FOLLOW_STRING_in_type1055); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING8_tree = (AstNode)adaptor.Create(STRING8);
                    		adaptor.AddChild(root_0, STRING8_tree);
                    	}

                    }
                    break;
                case 3 :
                    // MathExpr.g:122:22: DOUBLE
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	DOUBLE9=(IToken)Match(input,DOUBLE,FOLLOW_DOUBLE_in_type1059); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DOUBLE9_tree = (AstNode)adaptor.Create(DOUBLE9);
                    		adaptor.AddChild(root_0, DOUBLE9_tree);
                    	}

                    }
                    break;
                case 4 :
                    // MathExpr.g:122:31: FLOAT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FLOAT10=(IToken)Match(input,FLOAT,FOLLOW_FLOAT_in_type1063); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FLOAT10_tree = (AstNode)adaptor.Create(FLOAT10);
                    		adaptor.AddChild(root_0, FLOAT10_tree);
                    	}

                    }
                    break;
                case 5 :
                    // MathExpr.g:122:39: BOOL
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	BOOL11=(IToken)Match(input,BOOL,FOLLOW_BOOL_in_type1067); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BOOL11_tree = (AstNode)adaptor.Create(BOOL11);
                    		adaptor.AddChild(root_0, BOOL11_tree);
                    	}

                    }
                    break;
                case 6 :
                    // MathExpr.g:122:46: ( '[' type ']' )
                    {
                    	// MathExpr.g:122:46: ( '[' type ']' )
                    	// MathExpr.g:122:47: '[' type ']'
                    	{
                    		char_literal12=(IToken)Match(input,70,FOLLOW_70_in_type1072); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_70.Add(char_literal12);

                    		PushFollow(FOLLOW_type_in_type1074);
                    		type13 = type();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_type.Add(type13.Tree);
                    		char_literal14=(IToken)Match(input,71,FOLLOW_71_in_type1076); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_71.Add(char_literal14);


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
                    	// 122:61: -> ^( ARRAY type )
                    	{
                    	    // MathExpr.g:122:64: ^( ARRAY type )
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
    // MathExpr.g:124:1: value : ( NUMBER | TRUE | FALSE | STRINGVAL );
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
            // MathExpr.g:124:6: ( NUMBER | TRUE | FALSE | STRINGVAL )
            // MathExpr.g:
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	set15 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= TRUE && input.LA(1) <= FALSE) || (input.LA(1) >= NUMBER && input.LA(1) <= STRINGVAL) ) 
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
    // MathExpr.g:126:1: returnValue : ( term | value | IDENT );
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
            // MathExpr.g:126:12: ( term | value | IDENT )
            int alt4 = 3;
            switch ( input.LA(1) ) 
            {
            case NOT:
            case INCR:
            case DECR:
            case 74:
            	{
                alt4 = 1;
                }
                break;
            case IDENT:
            	{
                int LA4_2 = input.LA(2);

                if ( (synpred11_MathExpr()) )
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
            case TRUE:
            case FALSE:
            case NUMBER:
            case STRINGVAL:
            	{
                int LA4_3 = input.LA(2);

                if ( (synpred11_MathExpr()) )
                {
                    alt4 = 1;
                }
                else if ( (synpred12_MathExpr()) )
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
                    // MathExpr.g:126:14: term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_term_in_returnValue1112);
                    	term16 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term16.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:126:21: value
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_returnValue1116);
                    	value17 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value17.Tree);

                    }
                    break;
                case 3 :
                    // MathExpr.g:126:29: IDENT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IDENT18=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_returnValue1120); if (state.failed) return retval;
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
    // MathExpr.g:128:1: arrayValue : ( ( '[' returnValue ( ',' returnValue )* ']' ) | ( '[' arrayValue ( ',' arrayValue )* ']' ) -> ( ^( ARRAY arrayValue ) )* );
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
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_71 = new RewriteRuleTokenStream(adaptor,"token 71");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_arrayValue = new RewriteRuleSubtreeStream(adaptor,"rule arrayValue");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:128:11: ( ( '[' returnValue ( ',' returnValue )* ']' ) | ( '[' arrayValue ( ',' arrayValue )* ']' ) -> ( ^( ARRAY arrayValue ) )* )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == 70) )
            {
                int LA7_1 = input.LA(2);

                if ( (LA7_1 == NOT || (LA7_1 >= TRUE && LA7_1 <= FALSE) || (LA7_1 >= NUMBER && LA7_1 <= IDENT) || (LA7_1 >= INCR && LA7_1 <= DECR) || LA7_1 == 74) )
                {
                    alt7 = 1;
                }
                else if ( (LA7_1 == 70) )
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
                    // MathExpr.g:128:12: ( '[' returnValue ( ',' returnValue )* ']' )
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	// MathExpr.g:128:12: ( '[' returnValue ( ',' returnValue )* ']' )
                    	// MathExpr.g:128:13: '[' returnValue ( ',' returnValue )* ']'
                    	{
                    		char_literal19=(IToken)Match(input,70,FOLLOW_70_in_arrayValue1127); if (state.failed) return retval;
                    		PushFollow(FOLLOW_returnValue_in_arrayValue1130);
                    		returnValue20 = returnValue();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnValue20.Tree);
                    		// MathExpr.g:128:30: ( ',' returnValue )*
                    		do 
                    		{
                    		    int alt5 = 2;
                    		    int LA5_0 = input.LA(1);

                    		    if ( (LA5_0 == 72) )
                    		    {
                    		        alt5 = 1;
                    		    }


                    		    switch (alt5) 
                    			{
                    				case 1 :
                    				    // MathExpr.g:128:31: ',' returnValue
                    				    {
                    				    	char_literal21=(IToken)Match(input,72,FOLLOW_72_in_arrayValue1133); if (state.failed) return retval;
                    				    	PushFollow(FOLLOW_returnValue_in_arrayValue1136);
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

                    		char_literal23=(IToken)Match(input,71,FOLLOW_71_in_arrayValue1140); if (state.failed) return retval;

                    	}


                    }
                    break;
                case 2 :
                    // MathExpr.g:128:59: ( '[' arrayValue ( ',' arrayValue )* ']' )
                    {
                    	// MathExpr.g:128:59: ( '[' arrayValue ( ',' arrayValue )* ']' )
                    	// MathExpr.g:128:60: '[' arrayValue ( ',' arrayValue )* ']'
                    	{
                    		char_literal24=(IToken)Match(input,70,FOLLOW_70_in_arrayValue1148); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_70.Add(char_literal24);

                    		PushFollow(FOLLOW_arrayValue_in_arrayValue1150);
                    		arrayValue25 = arrayValue();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_arrayValue.Add(arrayValue25.Tree);
                    		// MathExpr.g:128:75: ( ',' arrayValue )*
                    		do 
                    		{
                    		    int alt6 = 2;
                    		    int LA6_0 = input.LA(1);

                    		    if ( (LA6_0 == 72) )
                    		    {
                    		        alt6 = 1;
                    		    }


                    		    switch (alt6) 
                    			{
                    				case 1 :
                    				    // MathExpr.g:128:76: ',' arrayValue
                    				    {
                    				    	char_literal26=(IToken)Match(input,72,FOLLOW_72_in_arrayValue1153); if (state.failed) return retval; 
                    				    	if ( (state.backtracking==0) ) stream_72.Add(char_literal26);

                    				    	PushFollow(FOLLOW_arrayValue_in_arrayValue1155);
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

                    		char_literal28=(IToken)Match(input,71,FOLLOW_71_in_arrayValue1159); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_71.Add(char_literal28);


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
                    	// 128:99: -> ( ^( ARRAY arrayValue ) )*
                    	{
                    	    // MathExpr.g:128:102: ( ^( ARRAY arrayValue ) )*
                    	    while ( stream_arrayValue.HasNext() )
                    	    {
                    	        // MathExpr.g:128:102: ^( ARRAY arrayValue )
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
    // MathExpr.g:130:1: crement : ( INCR idar -> ^( SINCR idar ) | idar INCR -> ^( EINCR idar ) | DECR idar -> ^( SDECR idar ) | idar DECR -> ^( EDECR idar ) );
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
        RewriteRuleTokenStream stream_INCR = new RewriteRuleTokenStream(adaptor,"token INCR");
        RewriteRuleTokenStream stream_DECR = new RewriteRuleTokenStream(adaptor,"token DECR");
        RewriteRuleSubtreeStream stream_idar = new RewriteRuleSubtreeStream(adaptor,"rule idar");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:130:8: ( INCR idar -> ^( SINCR idar ) | idar INCR -> ^( EINCR idar ) | DECR idar -> ^( SDECR idar ) | idar DECR -> ^( EDECR idar ) )
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

                if ( (synpred17_MathExpr()) )
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
                    // MathExpr.g:130:10: INCR idar
                    {
                    	INCR29=(IToken)Match(input,INCR,FOLLOW_INCR_in_crement1177); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INCR.Add(INCR29);

                    	PushFollow(FOLLOW_idar_in_crement1179);
                    	idar30 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idar.Add(idar30.Tree);


                    	// AST REWRITE
                    	// elements:          idar
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 130:20: -> ^( SINCR idar )
                    	{
                    	    // MathExpr.g:130:23: ^( SINCR idar )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(SINCR, "SINCR"), root_1);

                    	    adaptor.AddChild(root_1, stream_idar.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MathExpr.g:130:39: idar INCR
                    {
                    	PushFollow(FOLLOW_idar_in_crement1191);
                    	idar31 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idar.Add(idar31.Tree);
                    	INCR32=(IToken)Match(input,INCR,FOLLOW_INCR_in_crement1193); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INCR.Add(INCR32);



                    	// AST REWRITE
                    	// elements:          idar
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 130:49: -> ^( EINCR idar )
                    	{
                    	    // MathExpr.g:130:52: ^( EINCR idar )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(EINCR, "EINCR"), root_1);

                    	    adaptor.AddChild(root_1, stream_idar.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // MathExpr.g:130:68: DECR idar
                    {
                    	DECR33=(IToken)Match(input,DECR,FOLLOW_DECR_in_crement1205); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DECR.Add(DECR33);

                    	PushFollow(FOLLOW_idar_in_crement1207);
                    	idar34 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idar.Add(idar34.Tree);


                    	// AST REWRITE
                    	// elements:          idar
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 130:78: -> ^( SDECR idar )
                    	{
                    	    // MathExpr.g:130:81: ^( SDECR idar )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(SDECR, "SDECR"), root_1);

                    	    adaptor.AddChild(root_1, stream_idar.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // MathExpr.g:130:97: idar DECR
                    {
                    	PushFollow(FOLLOW_idar_in_crement1219);
                    	idar35 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idar.Add(idar35.Tree);
                    	DECR36=(IToken)Match(input,DECR,FOLLOW_DECR_in_crement1221); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DECR.Add(DECR36);



                    	// AST REWRITE
                    	// elements:          idar
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 130:107: -> ^( EDECR idar )
                    	{
                    	    // MathExpr.g:130:110: ^( EDECR idar )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(EDECR, "EDECR"), root_1);

                    	    adaptor.AddChild(root_1, stream_idar.NextTree());

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
    // MathExpr.g:132:1: allassign : ( ASSIGN | ADDAS | SUBAS | MULAS | DIVAS );
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
            // MathExpr.g:132:10: ( ASSIGN | ADDAS | SUBAS | MULAS | DIVAS )
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
    // MathExpr.g:134:1: swcase : ( CASE returnValue ( ',' returnValue )* ':' expr ) -> ^( CASE ^( CASEPARAM ( returnValue )* ) expr ) ;
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
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleTokenStream stream_CASE = new RewriteRuleTokenStream(adaptor,"token CASE");
        RewriteRuleSubtreeStream stream_returnValue = new RewriteRuleSubtreeStream(adaptor,"rule returnValue");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:134:7: ( ( CASE returnValue ( ',' returnValue )* ':' expr ) -> ^( CASE ^( CASEPARAM ( returnValue )* ) expr ) )
            // MathExpr.g:134:10: ( CASE returnValue ( ',' returnValue )* ':' expr )
            {
            	// MathExpr.g:134:10: ( CASE returnValue ( ',' returnValue )* ':' expr )
            	// MathExpr.g:134:11: CASE returnValue ( ',' returnValue )* ':' expr
            	{
            		CASE38=(IToken)Match(input,CASE,FOLLOW_CASE_in_swcase1262); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_CASE.Add(CASE38);

            		PushFollow(FOLLOW_returnValue_in_swcase1264);
            		returnValue39 = returnValue();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue39.Tree);
            		// MathExpr.g:134:28: ( ',' returnValue )*
            		do 
            		{
            		    int alt9 = 2;
            		    int LA9_0 = input.LA(1);

            		    if ( (LA9_0 == 72) )
            		    {
            		        alt9 = 1;
            		    }


            		    switch (alt9) 
            			{
            				case 1 :
            				    // MathExpr.g:134:29: ',' returnValue
            				    {
            				    	char_literal40=(IToken)Match(input,72,FOLLOW_72_in_swcase1267); if (state.failed) return retval; 
            				    	if ( (state.backtracking==0) ) stream_72.Add(char_literal40);

            				    	PushFollow(FOLLOW_returnValue_in_swcase1269);
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

            		char_literal42=(IToken)Match(input,73,FOLLOW_73_in_swcase1273); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_73.Add(char_literal42);

            		PushFollow(FOLLOW_expr_in_swcase1275);
            		expr43 = expr();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_expr.Add(expr43.Tree);

            	}



            	// AST REWRITE
            	// elements:          returnValue, expr, CASE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 134:59: -> ^( CASE ^( CASEPARAM ( returnValue )* ) expr )
            	{
            	    // MathExpr.g:134:62: ^( CASE ^( CASEPARAM ( returnValue )* ) expr )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot(stream_CASE.NextNode(), root_1);

            	    // MathExpr.g:134:69: ^( CASEPARAM ( returnValue )* )
            	    {
            	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	    root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(CASEPARAM, "CASEPARAM"), root_2);

            	    // MathExpr.g:134:81: ( returnValue )*
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
    // MathExpr.g:136:1: paramms : returnValue ( ',' returnValue )* -> ^( PARAMS ( returnValue )* ) ;
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
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_returnValue = new RewriteRuleSubtreeStream(adaptor,"rule returnValue");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:136:8: ( returnValue ( ',' returnValue )* -> ^( PARAMS ( returnValue )* ) )
            // MathExpr.g:137:1: returnValue ( ',' returnValue )*
            {
            	PushFollow(FOLLOW_returnValue_in_paramms1302);
            	returnValue44 = returnValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue44.Tree);
            	// MathExpr.g:137:13: ( ',' returnValue )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == 72) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MathExpr.g:137:14: ',' returnValue
            			    {
            			    	char_literal45=(IToken)Match(input,72,FOLLOW_72_in_paramms1305); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_72.Add(char_literal45);

            			    	PushFollow(FOLLOW_returnValue_in_paramms1307);
            			    	returnValue46 = returnValue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue46.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements



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
            	// 137:32: -> ^( PARAMS ( returnValue )* )
            	{
            	    // MathExpr.g:137:35: ^( PARAMS ( returnValue )* )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PARAMS, "PARAMS"), root_1);

            	    // MathExpr.g:137:44: ( returnValue )*
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
    // MathExpr.g:140:1: func_params : IDENT ':' type ( ',' IDENT ':' type )* -> ( ^( IDENT type ) )* ;
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
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:140:12: ( IDENT ':' type ( ',' IDENT ':' type )* -> ( ^( IDENT type ) )* )
            // MathExpr.g:141:1: IDENT ':' type ( ',' IDENT ':' type )*
            {
            	IDENT47=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_params1326); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT47);

            	char_literal48=(IToken)Match(input,73,FOLLOW_73_in_func_params1328); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_73.Add(char_literal48);

            	PushFollow(FOLLOW_type_in_func_params1330);
            	type49 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type49.Tree);
            	// MathExpr.g:141:16: ( ',' IDENT ':' type )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 72) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MathExpr.g:141:17: ',' IDENT ':' type
            			    {
            			    	char_literal50=(IToken)Match(input,72,FOLLOW_72_in_func_params1333); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_72.Add(char_literal50);

            			    	IDENT51=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_params1335); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT51);

            			    	char_literal52=(IToken)Match(input,73,FOLLOW_73_in_func_params1337); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_73.Add(char_literal52);

            			    	PushFollow(FOLLOW_type_in_func_params1339);
            			    	type53 = type();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_type.Add(type53.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements



            	// AST REWRITE
            	// elements:          type, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 141:38: -> ( ^( IDENT type ) )*
            	{
            	    // MathExpr.g:141:41: ( ^( IDENT type ) )*
            	    while ( stream_type.HasNext() || stream_IDENT.HasNext() )
            	    {
            	        // MathExpr.g:141:41: ^( IDENT type )
            	        {
            	        AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	        root_1 = (AstNode)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_1);

            	        adaptor.AddChild(root_1, stream_type.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_type.Reset();
            	    stream_IDENT.Reset();

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
    // MathExpr.g:144:1: func_call : IDENT '(' ( paramms )? ')' -> ^( FUNC_CALL IDENT ( paramms )? ) ;
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
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleSubtreeStream stream_paramms = new RewriteRuleSubtreeStream(adaptor,"rule paramms");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:144:10: ( IDENT '(' ( paramms )? ')' -> ^( FUNC_CALL IDENT ( paramms )? ) )
            // MathExpr.g:145:1: IDENT '(' ( paramms )? ')'
            {
            	IDENT54=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_call1358); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT54);

            	char_literal55=(IToken)Match(input,74,FOLLOW_74_in_func_call1360); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_74.Add(char_literal55);

            	// MathExpr.g:145:11: ( paramms )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == NOT || (LA12_0 >= TRUE && LA12_0 <= FALSE) || (LA12_0 >= NUMBER && LA12_0 <= IDENT) || (LA12_0 >= INCR && LA12_0 <= DECR) || LA12_0 == 74) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // MathExpr.g:0:0: paramms
            	        {
            	        	PushFollow(FOLLOW_paramms_in_func_call1362);
            	        	paramms56 = paramms();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_paramms.Add(paramms56.Tree);

            	        }
            	        break;

            	}

            	char_literal57=(IToken)Match(input,75,FOLLOW_75_in_func_call1365); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_75.Add(char_literal57);



            	// AST REWRITE
            	// elements:          paramms, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 145:24: -> ^( FUNC_CALL IDENT ( paramms )? )
            	{
            	    // MathExpr.g:145:27: ^( FUNC_CALL IDENT ( paramms )? )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // MathExpr.g:145:45: ( paramms )?
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

    public class var_element_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "var_element"
    // MathExpr.g:148:1: var_element : idar ( ':' type ( '(count' ':' add ')' ) )? ( ASSIGN ( returnValue | arrayValue ) )? -> ^( idar ( ^( TYPE type add ) )? ( ^( ASSIGN ( returnValue )? ( ^( ARRAY arrayValue ) )? ) )? ) ;
    public MathExprParser.var_element_return var_element() // throws RecognitionException [1]
    {   
        MathExprParser.var_element_return retval = new MathExprParser.var_element_return();
        retval.Start = input.LT(1);
        int var_element_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal59 = null;
        IToken string_literal61 = null;
        IToken char_literal62 = null;
        IToken char_literal64 = null;
        IToken ASSIGN65 = null;
        MathExprParser.idar_return idar58 = default(MathExprParser.idar_return);

        MathExprParser.type_return type60 = default(MathExprParser.type_return);

        MathExprParser.add_return add63 = default(MathExprParser.add_return);

        MathExprParser.returnValue_return returnValue66 = default(MathExprParser.returnValue_return);

        MathExprParser.arrayValue_return arrayValue67 = default(MathExprParser.arrayValue_return);


        AstNode char_literal59_tree=null;
        AstNode string_literal61_tree=null;
        AstNode char_literal62_tree=null;
        AstNode char_literal64_tree=null;
        AstNode ASSIGN65_tree=null;
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_returnValue = new RewriteRuleSubtreeStream(adaptor,"rule returnValue");
        RewriteRuleSubtreeStream stream_arrayValue = new RewriteRuleSubtreeStream(adaptor,"rule arrayValue");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_idar = new RewriteRuleSubtreeStream(adaptor,"rule idar");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:148:12: ( idar ( ':' type ( '(count' ':' add ')' ) )? ( ASSIGN ( returnValue | arrayValue ) )? -> ^( idar ( ^( TYPE type add ) )? ( ^( ASSIGN ( returnValue )? ( ^( ARRAY arrayValue ) )? ) )? ) )
            // MathExpr.g:148:14: idar ( ':' type ( '(count' ':' add ')' ) )? ( ASSIGN ( returnValue | arrayValue ) )?
            {
            	PushFollow(FOLLOW_idar_in_var_element1384);
            	idar58 = idar();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idar.Add(idar58.Tree);
            	// MathExpr.g:148:19: ( ':' type ( '(count' ':' add ')' ) )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 73) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // MathExpr.g:148:20: ':' type ( '(count' ':' add ')' )
            	        {
            	        	char_literal59=(IToken)Match(input,73,FOLLOW_73_in_var_element1387); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_73.Add(char_literal59);

            	        	PushFollow(FOLLOW_type_in_var_element1389);
            	        	type60 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type60.Tree);
            	        	// MathExpr.g:148:29: ( '(count' ':' add ')' )
            	        	// MathExpr.g:148:30: '(count' ':' add ')'
            	        	{
            	        		string_literal61=(IToken)Match(input,76,FOLLOW_76_in_var_element1392); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_76.Add(string_literal61);

            	        		char_literal62=(IToken)Match(input,73,FOLLOW_73_in_var_element1394); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_73.Add(char_literal62);

            	        		PushFollow(FOLLOW_add_in_var_element1396);
            	        		add63 = add();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_add.Add(add63.Tree);
            	        		char_literal64=(IToken)Match(input,75,FOLLOW_75_in_var_element1398); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_75.Add(char_literal64);


            	        	}


            	        }
            	        break;

            	}

            	// MathExpr.g:148:56: ( ASSIGN ( returnValue | arrayValue ) )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == ASSIGN) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // MathExpr.g:148:57: ASSIGN ( returnValue | arrayValue )
            	        {
            	        	ASSIGN65=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_var_element1406); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN65);

            	        	// MathExpr.g:148:64: ( returnValue | arrayValue )
            	        	int alt14 = 2;
            	        	int LA14_0 = input.LA(1);

            	        	if ( (LA14_0 == NOT || (LA14_0 >= TRUE && LA14_0 <= FALSE) || (LA14_0 >= NUMBER && LA14_0 <= IDENT) || (LA14_0 >= INCR && LA14_0 <= DECR) || LA14_0 == 74) )
            	        	{
            	        	    alt14 = 1;
            	        	}
            	        	else if ( (LA14_0 == 70) )
            	        	{
            	        	    alt14 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    NoViableAltException nvae_d14s0 =
            	        	        new NoViableAltException("", 14, 0, input);

            	        	    throw nvae_d14s0;
            	        	}
            	        	switch (alt14) 
            	        	{
            	        	    case 1 :
            	        	        // MathExpr.g:148:66: returnValue
            	        	        {
            	        	        	PushFollow(FOLLOW_returnValue_in_var_element1410);
            	        	        	returnValue66 = returnValue();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue66.Tree);

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MathExpr.g:148:80: arrayValue
            	        	        {
            	        	        	PushFollow(FOLLOW_arrayValue_in_var_element1414);
            	        	        	arrayValue67 = arrayValue();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_arrayValue.Add(arrayValue67.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          returnValue, arrayValue, ASSIGN, type, add, idar
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 148:94: -> ^( idar ( ^( TYPE type add ) )? ( ^( ASSIGN ( returnValue )? ( ^( ARRAY arrayValue ) )? ) )? )
            	{
            	    // MathExpr.g:148:97: ^( idar ( ^( TYPE type add ) )? ( ^( ASSIGN ( returnValue )? ( ^( ARRAY arrayValue ) )? ) )? )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot(stream_idar.NextNode(), root_1);

            	    // MathExpr.g:148:104: ( ^( TYPE type add ) )?
            	    if ( stream_type.HasNext() || stream_add.HasNext() )
            	    {
            	        // MathExpr.g:148:104: ^( TYPE type add )
            	        {
            	        AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	        root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(TYPE, "TYPE"), root_2);

            	        adaptor.AddChild(root_2, stream_type.NextTree());
            	        adaptor.AddChild(root_2, stream_add.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_type.Reset();
            	    stream_add.Reset();
            	    // MathExpr.g:148:122: ( ^( ASSIGN ( returnValue )? ( ^( ARRAY arrayValue ) )? ) )?
            	    if ( stream_returnValue.HasNext() || stream_arrayValue.HasNext() || stream_ASSIGN.HasNext() )
            	    {
            	        // MathExpr.g:148:122: ^( ASSIGN ( returnValue )? ( ^( ARRAY arrayValue ) )? )
            	        {
            	        AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	        root_2 = (AstNode)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_2);

            	        // MathExpr.g:148:131: ( returnValue )?
            	        if ( stream_returnValue.HasNext() )
            	        {
            	            adaptor.AddChild(root_2, stream_returnValue.NextTree());

            	        }
            	        stream_returnValue.Reset();
            	        // MathExpr.g:148:144: ( ^( ARRAY arrayValue ) )?
            	        if ( stream_arrayValue.HasNext() )
            	        {
            	            // MathExpr.g:148:144: ^( ARRAY arrayValue )
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
            	    stream_returnValue.Reset();
            	    stream_arrayValue.Reset();
            	    stream_ASSIGN.Reset();

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
            	Memoize(input, 13, var_element_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "var_element"

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
    // MathExpr.g:153:1: group : ( groupExpr | groupInit );
    public MathExprParser.group_return group() // throws RecognitionException [1]
    {   
        MathExprParser.group_return retval = new MathExprParser.group_return();
        retval.Start = input.LT(1);
        int group_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.groupExpr_return groupExpr68 = default(MathExprParser.groupExpr_return);

        MathExprParser.groupInit_return groupInit69 = default(MathExprParser.groupInit_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:153:6: ( groupExpr | groupInit )
            int alt16 = 2;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            	{
                int LA16_1 = input.LA(2);

                if ( (synpred30_MathExpr()) )
                {
                    alt16 = 1;
                }
                else if ( (true) )
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
                break;
            case INCR:
            case DECR:
            	{
                alt16 = 1;
                }
                break;
            case TRUE:
            case FALSE:
            case NUMBER:
            case STRINGVAL:
            case 74:
            	{
                alt16 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // MathExpr.g:154:2: groupExpr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_groupExpr_in_group1458);
                    	groupExpr68 = groupExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr68.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:154:15: groupInit
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_groupInit_in_group1463);
                    	groupInit69 = groupInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupInit69.Tree);

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
            	Memoize(input, 14, group_StartIndex); 
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
    // MathExpr.g:157:1: groupInit : ( '(' term ')' | IDENT | value | array );
    public MathExprParser.groupInit_return groupInit() // throws RecognitionException [1]
    {   
        MathExprParser.groupInit_return retval = new MathExprParser.groupInit_return();
        retval.Start = input.LT(1);
        int groupInit_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal70 = null;
        IToken char_literal72 = null;
        IToken IDENT73 = null;
        MathExprParser.term_return term71 = default(MathExprParser.term_return);

        MathExprParser.value_return value74 = default(MathExprParser.value_return);

        MathExprParser.array_return array75 = default(MathExprParser.array_return);


        AstNode char_literal70_tree=null;
        AstNode char_literal72_tree=null;
        AstNode IDENT73_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:157:10: ( '(' term ')' | IDENT | value | array )
            int alt17 = 4;
            switch ( input.LA(1) ) 
            {
            case 74:
            	{
                alt17 = 1;
                }
                break;
            case IDENT:
            	{
                int LA17_2 = input.LA(2);

                if ( (LA17_2 == EOF || LA17_2 == PRINT || (LA17_2 >= BEGIN && LA17_2 <= OR) || LA17_2 == LET || LA17_2 == REPEATE || LA17_2 == VAR || (LA17_2 >= FUNC && LA17_2 <= DEFAULT) || (LA17_2 >= IDENT && LA17_2 <= DIV) || (LA17_2 >= INCR && LA17_2 <= DECR) || (LA17_2 >= GE && LA17_2 <= LT) || (LA17_2 >= 71 && LA17_2 <= 73) || LA17_2 == 75 || (LA17_2 >= 77 && LA17_2 <= 78)) )
                {
                    alt17 = 2;
                }
                else if ( (LA17_2 == 70) )
                {
                    alt17 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d17s2 =
                        new NoViableAltException("", 17, 2, input);

                    throw nvae_d17s2;
                }
                }
                break;
            case TRUE:
            case FALSE:
            case NUMBER:
            case STRINGVAL:
            	{
                alt17 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            }

            switch (alt17) 
            {
                case 1 :
                    // MathExpr.g:158:3: '(' term ')'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	char_literal70=(IToken)Match(input,74,FOLLOW_74_in_groupInit1473); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_groupInit1476);
                    	term71 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term71.Tree);
                    	char_literal72=(IToken)Match(input,75,FOLLOW_75_in_groupInit1478); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MathExpr.g:159:3: IDENT
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IDENT73=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_groupInit1483); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT73_tree = (AstNode)adaptor.Create(IDENT73);
                    		adaptor.AddChild(root_0, IDENT73_tree);
                    	}

                    }
                    break;
                case 3 :
                    // MathExpr.g:160:3: value
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_groupInit1488);
                    	value74 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value74.Tree);

                    }
                    break;
                case 4 :
                    // MathExpr.g:161:3: array
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_array_in_groupInit1492);
                    	array75 = array();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array75.Tree);

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
            	Memoize(input, 15, groupInit_StartIndex); 
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
    // MathExpr.g:164:1: groupExpr : ( func_call | crement );
    public MathExprParser.groupExpr_return groupExpr() // throws RecognitionException [1]
    {   
        MathExprParser.groupExpr_return retval = new MathExprParser.groupExpr_return();
        retval.Start = input.LT(1);
        int groupExpr_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.func_call_return func_call76 = default(MathExprParser.func_call_return);

        MathExprParser.crement_return crement77 = default(MathExprParser.crement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:164:10: ( func_call | crement )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == IDENT) )
            {
                int LA18_1 = input.LA(2);

                if ( (LA18_1 == 74) )
                {
                    alt18 = 1;
                }
                else if ( ((LA18_1 >= INCR && LA18_1 <= DECR) || LA18_1 == 70) )
                {
                    alt18 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d18s1 =
                        new NoViableAltException("", 18, 1, input);

                    throw nvae_d18s1;
                }
            }
            else if ( ((LA18_0 >= INCR && LA18_0 <= DECR)) )
            {
                alt18 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // MathExpr.g:165:2: func_call
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_groupExpr1501);
                    	func_call76 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call76.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:166:5: crement
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_crement_in_groupExpr1507);
                    	crement77 = crement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, crement77.Tree);

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
            	Memoize(input, 16, groupExpr_StartIndex); 
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
    // MathExpr.g:170:1: not : ( NOT group | group );
    public MathExprParser.not_return not() // throws RecognitionException [1]
    {   
        MathExprParser.not_return retval = new MathExprParser.not_return();
        retval.Start = input.LT(1);
        int not_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken NOT78 = null;
        MathExprParser.group_return group79 = default(MathExprParser.group_return);

        MathExprParser.group_return group80 = default(MathExprParser.group_return);


        AstNode NOT78_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:170:4: ( NOT group | group )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == NOT) )
            {
                alt19 = 1;
            }
            else if ( ((LA19_0 >= TRUE && LA19_0 <= FALSE) || (LA19_0 >= NUMBER && LA19_0 <= IDENT) || (LA19_0 >= INCR && LA19_0 <= DECR) || LA19_0 == 74) )
            {
                alt19 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // MathExpr.g:171:3: NOT group
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	NOT78=(IToken)Match(input,NOT,FOLLOW_NOT_in_not1518); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT78_tree = (AstNode)adaptor.Create(NOT78);
                    		root_0 = (AstNode)adaptor.BecomeRoot(NOT78_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_group_in_not1521);
                    	group79 = group();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group79.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:172:3: group
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_group_in_not1525);
                    	group80 = group();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group80.Tree);

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
            	Memoize(input, 17, not_StartIndex); 
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
    // MathExpr.g:175:1: mult : not ( ( MUL | DIV ) not )* ;
    public MathExprParser.mult_return mult() // throws RecognitionException [1]
    {   
        MathExprParser.mult_return retval = new MathExprParser.mult_return();
        retval.Start = input.LT(1);
        int mult_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set82 = null;
        MathExprParser.not_return not81 = default(MathExprParser.not_return);

        MathExprParser.not_return not83 = default(MathExprParser.not_return);


        AstNode set82_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:175:5: ( not ( ( MUL | DIV ) not )* )
            // MathExpr.g:175:7: not ( ( MUL | DIV ) not )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_not_in_mult1533);
            	not81 = not();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not81.Tree);
            	// MathExpr.g:175:11: ( ( MUL | DIV ) not )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= MUL && LA20_0 <= DIV)) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // MathExpr.g:175:13: ( MUL | DIV ) not
            			    {
            			    	set82=(IToken)input.LT(1);
            			    	set82 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MUL && input.LA(1) <= DIV) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set82), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_not_in_mult1548);
            			    	not83 = not();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not83.Tree);

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements


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
            	Memoize(input, 18, mult_StartIndex); 
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
    // MathExpr.g:176:1: add : mult ( ( ADD | SUB ) mult )* ;
    public MathExprParser.add_return add() // throws RecognitionException [1]
    {   
        MathExprParser.add_return retval = new MathExprParser.add_return();
        retval.Start = input.LT(1);
        int add_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set85 = null;
        MathExprParser.mult_return mult84 = default(MathExprParser.mult_return);

        MathExprParser.mult_return mult86 = default(MathExprParser.mult_return);


        AstNode set85_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:176:4: ( mult ( ( ADD | SUB ) mult )* )
            // MathExpr.g:176:7: mult ( ( ADD | SUB ) mult )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1560);
            	mult84 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult84.Tree);
            	// MathExpr.g:176:13: ( ( ADD | SUB ) mult )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( ((LA21_0 >= ADD && LA21_0 <= SUB)) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // MathExpr.g:176:15: ( ADD | SUB ) mult
            			    {
            			    	set85=(IToken)input.LT(1);
            			    	set85 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= ADD && input.LA(1) <= SUB) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set85), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add1576);
            			    	mult86 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult86.Tree);

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
            	Memoize(input, 19, add_StartIndex); 
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
    // MathExpr.g:177:1: term : or_logic ;
    public MathExprParser.term_return term() // throws RecognitionException [1]
    {   
        MathExprParser.term_return retval = new MathExprParser.term_return();
        retval.Start = input.LT(1);
        int term_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.or_logic_return or_logic87 = default(MathExprParser.or_logic_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:177:5: ( or_logic )
            // MathExpr.g:177:7: or_logic
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_or_logic_in_term1588);
            	or_logic87 = or_logic();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or_logic87.Tree);

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
            	Memoize(input, 20, term_StartIndex); 
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
    // MathExpr.g:179:1: compare : add ( ( GE | LE | EQ | NE | LT | GT ) add )? ;
    public MathExprParser.compare_return compare() // throws RecognitionException [1]
    {   
        MathExprParser.compare_return retval = new MathExprParser.compare_return();
        retval.Start = input.LT(1);
        int compare_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set89 = null;
        MathExprParser.add_return add88 = default(MathExprParser.add_return);

        MathExprParser.add_return add90 = default(MathExprParser.add_return);


        AstNode set89_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:179:8: ( add ( ( GE | LE | EQ | NE | LT | GT ) add )? )
            // MathExpr.g:180:3: add ( ( GE | LE | EQ | NE | LT | GT ) add )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_compare1600);
            	add88 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add88.Tree);
            	// MathExpr.g:180:7: ( ( GE | LE | EQ | NE | LT | GT ) add )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( ((LA22_0 >= GE && LA22_0 <= LT)) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // MathExpr.g:180:8: ( GE | LE | EQ | NE | LT | GT ) add
            	        {
            	        	set89=(IToken)input.LT(1);
            	        	set89 = (IToken)input.LT(1);
            	        	if ( (input.LA(1) >= GE && input.LA(1) <= LT) ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set89), root_0);
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	PushFollow(FOLLOW_add_in_compare1618);
            	        	add90 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add90.Tree);

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
            	Memoize(input, 21, compare_StartIndex); 
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
    // MathExpr.g:183:1: and_logic : compare ( AND compare )* ;
    public MathExprParser.and_logic_return and_logic() // throws RecognitionException [1]
    {   
        MathExprParser.and_logic_return retval = new MathExprParser.and_logic_return();
        retval.Start = input.LT(1);
        int and_logic_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken AND92 = null;
        MathExprParser.compare_return compare91 = default(MathExprParser.compare_return);

        MathExprParser.compare_return compare93 = default(MathExprParser.compare_return);


        AstNode AND92_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:183:10: ( compare ( AND compare )* )
            // MathExpr.g:183:12: compare ( AND compare )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_compare_in_and_logic1628);
            	compare91 = compare();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare91.Tree);
            	// MathExpr.g:183:20: ( AND compare )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == AND) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // MathExpr.g:183:21: AND compare
            			    {
            			    	AND92=(IToken)Match(input,AND,FOLLOW_AND_in_and_logic1631); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{AND92_tree = (AstNode)adaptor.Create(AND92);
            			    		root_0 = (AstNode)adaptor.BecomeRoot(AND92_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_compare_in_and_logic1634);
            			    	compare93 = compare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare93.Tree);

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements


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
            	Memoize(input, 22, and_logic_StartIndex); 
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
    // MathExpr.g:184:1: or_logic : and_logic ( OR and_logic )* ;
    public MathExprParser.or_logic_return or_logic() // throws RecognitionException [1]
    {   
        MathExprParser.or_logic_return retval = new MathExprParser.or_logic_return();
        retval.Start = input.LT(1);
        int or_logic_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken OR95 = null;
        MathExprParser.and_logic_return and_logic94 = default(MathExprParser.and_logic_return);

        MathExprParser.and_logic_return and_logic96 = default(MathExprParser.and_logic_return);


        AstNode OR95_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:184:9: ( and_logic ( OR and_logic )* )
            // MathExpr.g:184:11: and_logic ( OR and_logic )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_and_logic_in_or_logic1643);
            	and_logic94 = and_logic();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic94.Tree);
            	// MathExpr.g:184:21: ( OR and_logic )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == OR) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // MathExpr.g:184:22: OR and_logic
            			    {
            			    	OR95=(IToken)Match(input,OR,FOLLOW_OR_in_or_logic1646); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{OR95_tree = (AstNode)adaptor.Create(OR95);
            			    		root_0 = (AstNode)adaptor.BecomeRoot(OR95_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_and_logic_in_or_logic1649);
            			    	and_logic96 = and_logic();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic96.Tree);

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


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
            	Memoize(input, 23, or_logic_StartIndex); 
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
    // MathExpr.g:188:1: expr : ( BEGIN exprList END -> ^( BLOCK ( exprList )? ) | idar allassign term | IF term expr ( ELSE expr )? | WHILE term expr | FOR ( VAR IDENT ASSIGN term )? ';' ( compare )? ';' ( groupExpr )? expr -> ^( FOR ( ^( VAR ^( IDENT TYPE ^( ASSIGN term ) ) ) )? ( compare )? ( groupExpr )? expr ) | LET idar ( ':' type )? ( ASSIGN returnValue )? ( ',' idar ( ':' type )? ( ASSIGN returnValue )? )* -> ^( LET ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ) )* ) | VAR var_element ( ',' var_element )* -> ^( VAR ( var_element )* ) | FOR ( VAR )? IDENT IN term '...' term expr | PRINT '(' ( STRINGVAL | idar ) ')' | groupExpr | REPEATE expr WHILE term -> ^( REPEATE term expr ) | FUNC IDENT '(' ( func_params )? ')' ( '->' type )? expr -> ^( FUNC IDENT ^( FUNC_PARAM ( func_params )? ) ^( TYPE ( type )? ) expr ) | RETURN ( returnValue | arrayValue ) -> ^( RETURN ( returnValue )? ( ^( ARRAY arrayValue ) )? ) | SWITCH IDENT '{' ( swcase )* ( DEFAULT ':' expr )? '}' -> ^( SWITCH IDENT ( swcase )* ( DEFAULT expr )? ) );
    public MathExprParser.expr_return expr() // throws RecognitionException [1]
    {   
        MathExprParser.expr_return retval = new MathExprParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken BEGIN97 = null;
        IToken END99 = null;
        IToken IF103 = null;
        IToken ELSE106 = null;
        IToken WHILE108 = null;
        IToken FOR111 = null;
        IToken VAR112 = null;
        IToken IDENT113 = null;
        IToken ASSIGN114 = null;
        IToken char_literal116 = null;
        IToken char_literal118 = null;
        IToken LET121 = null;
        IToken char_literal123 = null;
        IToken ASSIGN125 = null;
        IToken char_literal127 = null;
        IToken char_literal129 = null;
        IToken ASSIGN131 = null;
        IToken VAR133 = null;
        IToken char_literal135 = null;
        IToken FOR137 = null;
        IToken VAR138 = null;
        IToken IDENT139 = null;
        IToken IN140 = null;
        IToken string_literal142 = null;
        IToken PRINT145 = null;
        IToken char_literal146 = null;
        IToken STRINGVAL147 = null;
        IToken char_literal149 = null;
        IToken REPEATE151 = null;
        IToken WHILE153 = null;
        IToken FUNC155 = null;
        IToken IDENT156 = null;
        IToken char_literal157 = null;
        IToken char_literal159 = null;
        IToken string_literal160 = null;
        IToken RETURN163 = null;
        IToken SWITCH166 = null;
        IToken IDENT167 = null;
        IToken char_literal168 = null;
        IToken DEFAULT170 = null;
        IToken char_literal171 = null;
        IToken char_literal173 = null;
        MathExprParser.exprList_return exprList98 = default(MathExprParser.exprList_return);

        MathExprParser.idar_return idar100 = default(MathExprParser.idar_return);

        MathExprParser.allassign_return allassign101 = default(MathExprParser.allassign_return);

        MathExprParser.term_return term102 = default(MathExprParser.term_return);

        MathExprParser.term_return term104 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr105 = default(MathExprParser.expr_return);

        MathExprParser.expr_return expr107 = default(MathExprParser.expr_return);

        MathExprParser.term_return term109 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr110 = default(MathExprParser.expr_return);

        MathExprParser.term_return term115 = default(MathExprParser.term_return);

        MathExprParser.compare_return compare117 = default(MathExprParser.compare_return);

        MathExprParser.groupExpr_return groupExpr119 = default(MathExprParser.groupExpr_return);

        MathExprParser.expr_return expr120 = default(MathExprParser.expr_return);

        MathExprParser.idar_return idar122 = default(MathExprParser.idar_return);

        MathExprParser.type_return type124 = default(MathExprParser.type_return);

        MathExprParser.returnValue_return returnValue126 = default(MathExprParser.returnValue_return);

        MathExprParser.idar_return idar128 = default(MathExprParser.idar_return);

        MathExprParser.type_return type130 = default(MathExprParser.type_return);

        MathExprParser.returnValue_return returnValue132 = default(MathExprParser.returnValue_return);

        MathExprParser.var_element_return var_element134 = default(MathExprParser.var_element_return);

        MathExprParser.var_element_return var_element136 = default(MathExprParser.var_element_return);

        MathExprParser.term_return term141 = default(MathExprParser.term_return);

        MathExprParser.term_return term143 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr144 = default(MathExprParser.expr_return);

        MathExprParser.idar_return idar148 = default(MathExprParser.idar_return);

        MathExprParser.groupExpr_return groupExpr150 = default(MathExprParser.groupExpr_return);

        MathExprParser.expr_return expr152 = default(MathExprParser.expr_return);

        MathExprParser.term_return term154 = default(MathExprParser.term_return);

        MathExprParser.func_params_return func_params158 = default(MathExprParser.func_params_return);

        MathExprParser.type_return type161 = default(MathExprParser.type_return);

        MathExprParser.expr_return expr162 = default(MathExprParser.expr_return);

        MathExprParser.returnValue_return returnValue164 = default(MathExprParser.returnValue_return);

        MathExprParser.arrayValue_return arrayValue165 = default(MathExprParser.arrayValue_return);

        MathExprParser.swcase_return swcase169 = default(MathExprParser.swcase_return);

        MathExprParser.expr_return expr172 = default(MathExprParser.expr_return);


        AstNode BEGIN97_tree=null;
        AstNode END99_tree=null;
        AstNode IF103_tree=null;
        AstNode ELSE106_tree=null;
        AstNode WHILE108_tree=null;
        AstNode FOR111_tree=null;
        AstNode VAR112_tree=null;
        AstNode IDENT113_tree=null;
        AstNode ASSIGN114_tree=null;
        AstNode char_literal116_tree=null;
        AstNode char_literal118_tree=null;
        AstNode LET121_tree=null;
        AstNode char_literal123_tree=null;
        AstNode ASSIGN125_tree=null;
        AstNode char_literal127_tree=null;
        AstNode char_literal129_tree=null;
        AstNode ASSIGN131_tree=null;
        AstNode VAR133_tree=null;
        AstNode char_literal135_tree=null;
        AstNode FOR137_tree=null;
        AstNode VAR138_tree=null;
        AstNode IDENT139_tree=null;
        AstNode IN140_tree=null;
        AstNode string_literal142_tree=null;
        AstNode PRINT145_tree=null;
        AstNode char_literal146_tree=null;
        AstNode STRINGVAL147_tree=null;
        AstNode char_literal149_tree=null;
        AstNode REPEATE151_tree=null;
        AstNode WHILE153_tree=null;
        AstNode FUNC155_tree=null;
        AstNode IDENT156_tree=null;
        AstNode char_literal157_tree=null;
        AstNode char_literal159_tree=null;
        AstNode string_literal160_tree=null;
        AstNode RETURN163_tree=null;
        AstNode SWITCH166_tree=null;
        AstNode IDENT167_tree=null;
        AstNode char_literal168_tree=null;
        AstNode DEFAULT170_tree=null;
        AstNode char_literal171_tree=null;
        AstNode char_literal173_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_FUNC = new RewriteRuleTokenStream(adaptor,"token FUNC");
        RewriteRuleTokenStream stream_VAR = new RewriteRuleTokenStream(adaptor,"token VAR");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_REPEATE = new RewriteRuleTokenStream(adaptor,"token REPEATE");
        RewriteRuleTokenStream stream_RETURN = new RewriteRuleTokenStream(adaptor,"token RETURN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_LET = new RewriteRuleTokenStream(adaptor,"token LET");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_SWITCH = new RewriteRuleTokenStream(adaptor,"token SWITCH");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleTokenStream stream_DEFAULT = new RewriteRuleTokenStream(adaptor,"token DEFAULT");
        RewriteRuleSubtreeStream stream_groupExpr = new RewriteRuleSubtreeStream(adaptor,"rule groupExpr");
        RewriteRuleSubtreeStream stream_compare = new RewriteRuleSubtreeStream(adaptor,"rule compare");
        RewriteRuleSubtreeStream stream_returnValue = new RewriteRuleSubtreeStream(adaptor,"rule returnValue");
        RewriteRuleSubtreeStream stream_func_params = new RewriteRuleSubtreeStream(adaptor,"rule func_params");
        RewriteRuleSubtreeStream stream_exprList = new RewriteRuleSubtreeStream(adaptor,"rule exprList");
        RewriteRuleSubtreeStream stream_term = new RewriteRuleSubtreeStream(adaptor,"rule term");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        RewriteRuleSubtreeStream stream_arrayValue = new RewriteRuleSubtreeStream(adaptor,"rule arrayValue");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_swcase = new RewriteRuleSubtreeStream(adaptor,"rule swcase");
        RewriteRuleSubtreeStream stream_idar = new RewriteRuleSubtreeStream(adaptor,"rule idar");
        RewriteRuleSubtreeStream stream_var_element = new RewriteRuleSubtreeStream(adaptor,"rule var_element");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:188:5: ( BEGIN exprList END -> ^( BLOCK ( exprList )? ) | idar allassign term | IF term expr ( ELSE expr )? | WHILE term expr | FOR ( VAR IDENT ASSIGN term )? ';' ( compare )? ';' ( groupExpr )? expr -> ^( FOR ( ^( VAR ^( IDENT TYPE ^( ASSIGN term ) ) ) )? ( compare )? ( groupExpr )? expr ) | LET idar ( ':' type )? ( ASSIGN returnValue )? ( ',' idar ( ':' type )? ( ASSIGN returnValue )? )* -> ^( LET ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ) )* ) | VAR var_element ( ',' var_element )* -> ^( VAR ( var_element )* ) | FOR ( VAR )? IDENT IN term '...' term expr | PRINT '(' ( STRINGVAL | idar ) ')' | groupExpr | REPEATE expr WHILE term -> ^( REPEATE term expr ) | FUNC IDENT '(' ( func_params )? ')' ( '->' type )? expr -> ^( FUNC IDENT ^( FUNC_PARAM ( func_params )? ) ^( TYPE ( type )? ) expr ) | RETURN ( returnValue | arrayValue ) -> ^( RETURN ( returnValue )? ( ^( ARRAY arrayValue ) )? ) | SWITCH IDENT '{' ( swcase )* ( DEFAULT ':' expr )? '}' -> ^( SWITCH IDENT ( swcase )* ( DEFAULT expr )? ) )
            int alt42 = 14;
            alt42 = dfa42.Predict(input);
            switch (alt42) 
            {
                case 1 :
                    // MathExpr.g:189:3: BEGIN exprList END
                    {
                    	BEGIN97=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_expr1663); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BEGIN.Add(BEGIN97);

                    	PushFollow(FOLLOW_exprList_in_expr1665);
                    	exprList98 = exprList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exprList.Add(exprList98.Tree);
                    	END99=(IToken)Match(input,END,FOLLOW_END_in_expr1667); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_END.Add(END99);



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
                    	// 189:22: -> ^( BLOCK ( exprList )? )
                    	{
                    	    // MathExpr.g:189:25: ^( BLOCK ( exprList )? )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(BLOCK, "BLOCK"), root_1);

                    	    // MathExpr.g:189:33: ( exprList )?
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
                    // MathExpr.g:190:3: idar allassign term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idar_in_expr1680);
                    	idar100 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idar100.Tree);
                    	PushFollow(FOLLOW_allassign_in_expr1682);
                    	allassign101 = allassign();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot(allassign101.Tree, root_0);
                    	PushFollow(FOLLOW_term_in_expr1685);
                    	term102 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term102.Tree);

                    }
                    break;
                case 3 :
                    // MathExpr.g:191:3: IF term expr ( ELSE expr )?
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IF103=(IToken)Match(input,IF,FOLLOW_IF_in_expr1689); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF103_tree = (AstNode)adaptor.Create(IF103);
                    		root_0 = (AstNode)adaptor.BecomeRoot(IF103_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr1692);
                    	term104 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term104.Tree);
                    	PushFollow(FOLLOW_expr_in_expr1694);
                    	expr105 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr105.Tree);
                    	// MathExpr.g:191:17: ( ELSE expr )?
                    	int alt25 = 2;
                    	int LA25_0 = input.LA(1);

                    	if ( (LA25_0 == ELSE) )
                    	{
                    	    int LA25_1 = input.LA(2);

                    	    if ( (synpred50_MathExpr()) )
                    	    {
                    	        alt25 = 1;
                    	    }
                    	}
                    	switch (alt25) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:191:18: ELSE expr
                    	        {
                    	        	ELSE106=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr1697); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr1700);
                    	        	expr107 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr107.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // MathExpr.g:192:3: WHILE term expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	WHILE108=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr1706); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE108_tree = (AstNode)adaptor.Create(WHILE108);
                    		root_0 = (AstNode)adaptor.BecomeRoot(WHILE108_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr1709);
                    	term109 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term109.Tree);
                    	PushFollow(FOLLOW_expr_in_expr1712);
                    	expr110 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr110.Tree);

                    }
                    break;
                case 5 :
                    // MathExpr.g:193:3: FOR ( VAR IDENT ASSIGN term )? ';' ( compare )? ';' ( groupExpr )? expr
                    {
                    	FOR111=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr1716); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_FOR.Add(FOR111);

                    	// MathExpr.g:193:7: ( VAR IDENT ASSIGN term )?
                    	int alt26 = 2;
                    	int LA26_0 = input.LA(1);

                    	if ( (LA26_0 == VAR) )
                    	{
                    	    alt26 = 1;
                    	}
                    	switch (alt26) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:193:8: VAR IDENT ASSIGN term
                    	        {
                    	        	VAR112=(IToken)Match(input,VAR,FOLLOW_VAR_in_expr1719); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_VAR.Add(VAR112);

                    	        	IDENT113=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1721); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT113);

                    	        	ASSIGN114=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1723); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN114);

                    	        	PushFollow(FOLLOW_term_in_expr1725);
                    	        	term115 = term();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_term.Add(term115.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal116=(IToken)Match(input,77,FOLLOW_77_in_expr1730); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_77.Add(char_literal116);

                    	// MathExpr.g:193:37: ( compare )?
                    	int alt27 = 2;
                    	int LA27_0 = input.LA(1);

                    	if ( (LA27_0 == NOT || (LA27_0 >= TRUE && LA27_0 <= FALSE) || (LA27_0 >= NUMBER && LA27_0 <= IDENT) || (LA27_0 >= INCR && LA27_0 <= DECR) || LA27_0 == 74) )
                    	{
                    	    alt27 = 1;
                    	}
                    	switch (alt27) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:0:0: compare
                    	        {
                    	        	PushFollow(FOLLOW_compare_in_expr1732);
                    	        	compare117 = compare();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_compare.Add(compare117.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal118=(IToken)Match(input,77,FOLLOW_77_in_expr1735); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_77.Add(char_literal118);

                    	// MathExpr.g:193:50: ( groupExpr )?
                    	int alt28 = 2;
                    	alt28 = dfa28.Predict(input);
                    	switch (alt28) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:193:52: groupExpr
                    	        {
                    	        	PushFollow(FOLLOW_groupExpr_in_expr1739);
                    	        	groupExpr119 = groupExpr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_groupExpr.Add(groupExpr119.Tree);

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_expr_in_expr1743);
                    	expr120 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr120.Tree);


                    	// AST REWRITE
                    	// elements:          term, FOR, IDENT, groupExpr, ASSIGN, VAR, compare, expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 193:69: -> ^( FOR ( ^( VAR ^( IDENT TYPE ^( ASSIGN term ) ) ) )? ( compare )? ( groupExpr )? expr )
                    	{
                    	    // MathExpr.g:193:72: ^( FOR ( ^( VAR ^( IDENT TYPE ^( ASSIGN term ) ) ) )? ( compare )? ( groupExpr )? expr )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

                    	    // MathExpr.g:193:78: ( ^( VAR ^( IDENT TYPE ^( ASSIGN term ) ) ) )?
                    	    if ( stream_term.HasNext() || stream_IDENT.HasNext() || stream_ASSIGN.HasNext() || stream_VAR.HasNext() )
                    	    {
                    	        // MathExpr.g:193:78: ^( VAR ^( IDENT TYPE ^( ASSIGN term ) ) )
                    	        {
                    	        AstNode root_2 = (AstNode)adaptor.GetNilNode();
                    	        root_2 = (AstNode)adaptor.BecomeRoot(stream_VAR.NextNode(), root_2);

                    	        // MathExpr.g:193:84: ^( IDENT TYPE ^( ASSIGN term ) )
                    	        {
                    	        AstNode root_3 = (AstNode)adaptor.GetNilNode();
                    	        root_3 = (AstNode)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_3);

                    	        adaptor.AddChild(root_3, (AstNode)adaptor.Create(TYPE, "TYPE"));
                    	        // MathExpr.g:193:97: ^( ASSIGN term )
                    	        {
                    	        AstNode root_4 = (AstNode)adaptor.GetNilNode();
                    	        root_4 = (AstNode)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_4);

                    	        adaptor.AddChild(root_4, stream_term.NextTree());

                    	        adaptor.AddChild(root_3, root_4);
                    	        }

                    	        adaptor.AddChild(root_2, root_3);
                    	        }

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_term.Reset();
                    	    stream_IDENT.Reset();
                    	    stream_ASSIGN.Reset();
                    	    stream_VAR.Reset();
                    	    // MathExpr.g:193:115: ( compare )?
                    	    if ( stream_compare.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_compare.NextTree());

                    	    }
                    	    stream_compare.Reset();
                    	    // MathExpr.g:193:124: ( groupExpr )?
                    	    if ( stream_groupExpr.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_groupExpr.NextTree());

                    	    }
                    	    stream_groupExpr.Reset();
                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // MathExpr.g:194:3: LET idar ( ':' type )? ( ASSIGN returnValue )? ( ',' idar ( ':' type )? ( ASSIGN returnValue )? )*
                    {
                    	LET121=(IToken)Match(input,LET,FOLLOW_LET_in_expr1778); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LET.Add(LET121);

                    	PushFollow(FOLLOW_idar_in_expr1780);
                    	idar122 = idar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idar.Add(idar122.Tree);
                    	// MathExpr.g:194:12: ( ':' type )?
                    	int alt29 = 2;
                    	int LA29_0 = input.LA(1);

                    	if ( (LA29_0 == 73) )
                    	{
                    	    alt29 = 1;
                    	}
                    	switch (alt29) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:194:13: ':' type
                    	        {
                    	        	char_literal123=(IToken)Match(input,73,FOLLOW_73_in_expr1783); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_73.Add(char_literal123);

                    	        	PushFollow(FOLLOW_type_in_expr1785);
                    	        	type124 = type();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_type.Add(type124.Tree);

                    	        }
                    	        break;

                    	}

                    	// MathExpr.g:194:24: ( ASSIGN returnValue )?
                    	int alt30 = 2;
                    	int LA30_0 = input.LA(1);

                    	if ( (LA30_0 == ASSIGN) )
                    	{
                    	    alt30 = 1;
                    	}
                    	switch (alt30) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:194:25: ASSIGN returnValue
                    	        {
                    	        	ASSIGN125=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1790); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN125);

                    	        	PushFollow(FOLLOW_returnValue_in_expr1792);
                    	        	returnValue126 = returnValue();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue126.Tree);

                    	        }
                    	        break;

                    	}

                    	// MathExpr.g:194:46: ( ',' idar ( ':' type )? ( ASSIGN returnValue )? )*
                    	do 
                    	{
                    	    int alt33 = 2;
                    	    int LA33_0 = input.LA(1);

                    	    if ( (LA33_0 == 72) )
                    	    {
                    	        alt33 = 1;
                    	    }


                    	    switch (alt33) 
                    		{
                    			case 1 :
                    			    // MathExpr.g:194:47: ',' idar ( ':' type )? ( ASSIGN returnValue )?
                    			    {
                    			    	char_literal127=(IToken)Match(input,72,FOLLOW_72_in_expr1797); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_72.Add(char_literal127);

                    			    	PushFollow(FOLLOW_idar_in_expr1799);
                    			    	idar128 = idar();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_idar.Add(idar128.Tree);
                    			    	// MathExpr.g:194:56: ( ':' type )?
                    			    	int alt31 = 2;
                    			    	int LA31_0 = input.LA(1);

                    			    	if ( (LA31_0 == 73) )
                    			    	{
                    			    	    alt31 = 1;
                    			    	}
                    			    	switch (alt31) 
                    			    	{
                    			    	    case 1 :
                    			    	        // MathExpr.g:194:57: ':' type
                    			    	        {
                    			    	        	char_literal129=(IToken)Match(input,73,FOLLOW_73_in_expr1802); if (state.failed) return retval; 
                    			    	        	if ( (state.backtracking==0) ) stream_73.Add(char_literal129);

                    			    	        	PushFollow(FOLLOW_type_in_expr1804);
                    			    	        	type130 = type();
                    			    	        	state.followingStackPointer--;
                    			    	        	if (state.failed) return retval;
                    			    	        	if ( (state.backtracking==0) ) stream_type.Add(type130.Tree);

                    			    	        }
                    			    	        break;

                    			    	}

                    			    	// MathExpr.g:194:68: ( ASSIGN returnValue )?
                    			    	int alt32 = 2;
                    			    	int LA32_0 = input.LA(1);

                    			    	if ( (LA32_0 == ASSIGN) )
                    			    	{
                    			    	    alt32 = 1;
                    			    	}
                    			    	switch (alt32) 
                    			    	{
                    			    	    case 1 :
                    			    	        // MathExpr.g:194:69: ASSIGN returnValue
                    			    	        {
                    			    	        	ASSIGN131=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1809); if (state.failed) return retval; 
                    			    	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN131);

                    			    	        	PushFollow(FOLLOW_returnValue_in_expr1811);
                    			    	        	returnValue132 = returnValue();
                    			    	        	state.followingStackPointer--;
                    			    	        	if (state.failed) return retval;
                    			    	        	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue132.Tree);

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
                    	// elements:          idar, LET, returnValue, type, ASSIGN
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 194:93: -> ^( LET ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ) )* )
                    	{
                    	    // MathExpr.g:194:96: ^( LET ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ) )* )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_LET.NextNode(), root_1);

                    	    // MathExpr.g:194:102: ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ) )*
                    	    while ( stream_idar.HasNext() )
                    	    {
                    	        // MathExpr.g:194:102: ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? )
                    	        {
                    	        AstNode root_2 = (AstNode)adaptor.GetNilNode();
                    	        root_2 = (AstNode)adaptor.BecomeRoot(stream_idar.NextNode(), root_2);

                    	        // MathExpr.g:194:109: ^( TYPE ( type )? )
                    	        {
                    	        AstNode root_3 = (AstNode)adaptor.GetNilNode();
                    	        root_3 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(TYPE, "TYPE"), root_3);

                    	        // MathExpr.g:194:116: ( type )?
                    	        if ( stream_type.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_3, stream_type.NextTree());

                    	        }
                    	        stream_type.Reset();

                    	        adaptor.AddChild(root_2, root_3);
                    	        }
                    	        // MathExpr.g:194:123: ( ^( ASSIGN returnValue ) )?
                    	        if ( stream_returnValue.HasNext() || stream_ASSIGN.HasNext() )
                    	        {
                    	            // MathExpr.g:194:123: ^( ASSIGN returnValue )
                    	            {
                    	            AstNode root_3 = (AstNode)adaptor.GetNilNode();
                    	            root_3 = (AstNode)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_3);

                    	            adaptor.AddChild(root_3, stream_returnValue.NextTree());

                    	            adaptor.AddChild(root_2, root_3);
                    	            }

                    	        }
                    	        stream_returnValue.Reset();
                    	        stream_ASSIGN.Reset();

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
                case 7 :
                    // MathExpr.g:195:3: VAR var_element ( ',' var_element )*
                    {
                    	VAR133=(IToken)Match(input,VAR,FOLLOW_VAR_in_expr1846); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_VAR.Add(VAR133);

                    	PushFollow(FOLLOW_var_element_in_expr1848);
                    	var_element134 = var_element();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_var_element.Add(var_element134.Tree);
                    	// MathExpr.g:195:19: ( ',' var_element )*
                    	do 
                    	{
                    	    int alt34 = 2;
                    	    int LA34_0 = input.LA(1);

                    	    if ( (LA34_0 == 72) )
                    	    {
                    	        alt34 = 1;
                    	    }


                    	    switch (alt34) 
                    		{
                    			case 1 :
                    			    // MathExpr.g:195:20: ',' var_element
                    			    {
                    			    	char_literal135=(IToken)Match(input,72,FOLLOW_72_in_expr1851); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_72.Add(char_literal135);

                    			    	PushFollow(FOLLOW_var_element_in_expr1853);
                    			    	var_element136 = var_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_var_element.Add(var_element136.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop34;
                    	    }
                    	} while (true);

                    	loop34:
                    		;	// Stops C# compiler whining that label 'loop34' has no statements



                    	// AST REWRITE
                    	// elements:          VAR, var_element
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 195:38: -> ^( VAR ( var_element )* )
                    	{
                    	    // MathExpr.g:195:41: ^( VAR ( var_element )* )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

                    	    // MathExpr.g:195:47: ( var_element )*
                    	    while ( stream_var_element.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_var_element.NextTree());

                    	    }
                    	    stream_var_element.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 8 :
                    // MathExpr.g:196:3: FOR ( VAR )? IDENT IN term '...' term expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FOR137=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr1868); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR137_tree = (AstNode)adaptor.Create(FOR137);
                    		root_0 = (AstNode)adaptor.BecomeRoot(FOR137_tree, root_0);
                    	}
                    	// MathExpr.g:196:11: ( VAR )?
                    	int alt35 = 2;
                    	int LA35_0 = input.LA(1);

                    	if ( (LA35_0 == VAR) )
                    	{
                    	    alt35 = 1;
                    	}
                    	switch (alt35) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:0:0: VAR
                    	        {
                    	        	VAR138=(IToken)Match(input,VAR,FOLLOW_VAR_in_expr1871); if (state.failed) return retval;

                    	        }
                    	        break;

                    	}

                    	IDENT139=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1875); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT139_tree = (AstNode)adaptor.Create(IDENT139);
                    		adaptor.AddChild(root_0, IDENT139_tree);
                    	}
                    	IN140=(IToken)Match(input,IN,FOLLOW_IN_in_expr1877); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_expr1880);
                    	term141 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term141.Tree);
                    	string_literal142=(IToken)Match(input,78,FOLLOW_78_in_expr1882); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_expr1885);
                    	term143 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term143.Tree);
                    	PushFollow(FOLLOW_expr_in_expr1887);
                    	expr144 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr144.Tree);

                    }
                    break;
                case 9 :
                    // MathExpr.g:197:3: PRINT '(' ( STRINGVAL | idar ) ')'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PRINT145=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_expr1891); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PRINT145_tree = (AstNode)adaptor.Create(PRINT145);
                    		root_0 = (AstNode)adaptor.BecomeRoot(PRINT145_tree, root_0);
                    	}
                    	char_literal146=(IToken)Match(input,74,FOLLOW_74_in_expr1894); if (state.failed) return retval;
                    	// MathExpr.g:197:15: ( STRINGVAL | idar )
                    	int alt36 = 2;
                    	int LA36_0 = input.LA(1);

                    	if ( (LA36_0 == STRINGVAL) )
                    	{
                    	    alt36 = 1;
                    	}
                    	else if ( (LA36_0 == IDENT) )
                    	{
                    	    alt36 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d36s0 =
                    	        new NoViableAltException("", 36, 0, input);

                    	    throw nvae_d36s0;
                    	}
                    	switch (alt36) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:197:17: STRINGVAL
                    	        {
                    	        	STRINGVAL147=(IToken)Match(input,STRINGVAL,FOLLOW_STRINGVAL_in_expr1899); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{STRINGVAL147_tree = (AstNode)adaptor.Create(STRINGVAL147);
                    	        		adaptor.AddChild(root_0, STRINGVAL147_tree);
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // MathExpr.g:197:29: idar
                    	        {
                    	        	PushFollow(FOLLOW_idar_in_expr1903);
                    	        	idar148 = idar();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idar148.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal149=(IToken)Match(input,75,FOLLOW_75_in_expr1907); if (state.failed) return retval;

                    }
                    break;
                case 10 :
                    // MathExpr.g:198:3: groupExpr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_groupExpr_in_expr1912);
                    	groupExpr150 = groupExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr150.Tree);

                    }
                    break;
                case 11 :
                    // MathExpr.g:199:3: REPEATE expr WHILE term
                    {
                    	REPEATE151=(IToken)Match(input,REPEATE,FOLLOW_REPEATE_in_expr1916); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_REPEATE.Add(REPEATE151);

                    	PushFollow(FOLLOW_expr_in_expr1918);
                    	expr152 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr152.Tree);
                    	WHILE153=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr1920); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE153);

                    	PushFollow(FOLLOW_term_in_expr1922);
                    	term154 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_term.Add(term154.Tree);


                    	// AST REWRITE
                    	// elements:          expr, REPEATE, term
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 199:27: -> ^( REPEATE term expr )
                    	{
                    	    // MathExpr.g:199:30: ^( REPEATE term expr )
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
                    // MathExpr.g:200:3: FUNC IDENT '(' ( func_params )? ')' ( '->' type )? expr
                    {
                    	FUNC155=(IToken)Match(input,FUNC,FOLLOW_FUNC_in_expr1936); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_FUNC.Add(FUNC155);

                    	IDENT156=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr1938); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT156);

                    	char_literal157=(IToken)Match(input,74,FOLLOW_74_in_expr1940); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_74.Add(char_literal157);

                    	// MathExpr.g:200:18: ( func_params )?
                    	int alt37 = 2;
                    	int LA37_0 = input.LA(1);

                    	if ( (LA37_0 == IDENT) )
                    	{
                    	    alt37 = 1;
                    	}
                    	switch (alt37) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:0:0: func_params
                    	        {
                    	        	PushFollow(FOLLOW_func_params_in_expr1942);
                    	        	func_params158 = func_params();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_func_params.Add(func_params158.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal159=(IToken)Match(input,75,FOLLOW_75_in_expr1945); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_75.Add(char_literal159);

                    	// MathExpr.g:200:35: ( '->' type )?
                    	int alt38 = 2;
                    	int LA38_0 = input.LA(1);

                    	if ( (LA38_0 == 79) )
                    	{
                    	    alt38 = 1;
                    	}
                    	switch (alt38) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:200:36: '->' type
                    	        {
                    	        	string_literal160=(IToken)Match(input,79,FOLLOW_79_in_expr1948); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_79.Add(string_literal160);

                    	        	PushFollow(FOLLOW_type_in_expr1950);
                    	        	type161 = type();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_type.Add(type161.Tree);

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_expr_in_expr1954);
                    	expr162 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr162.Tree);


                    	// AST REWRITE
                    	// elements:          func_params, IDENT, type, FUNC, expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 200:53: -> ^( FUNC IDENT ^( FUNC_PARAM ( func_params )? ) ^( TYPE ( type )? ) expr )
                    	{
                    	    // MathExpr.g:200:56: ^( FUNC IDENT ^( FUNC_PARAM ( func_params )? ) ^( TYPE ( type )? ) expr )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_FUNC.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
                    	    // MathExpr.g:200:69: ^( FUNC_PARAM ( func_params )? )
                    	    {
                    	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
                    	    root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(FUNC_PARAM, "FUNC_PARAM"), root_2);

                    	    // MathExpr.g:200:83: ( func_params )?
                    	    if ( stream_func_params.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_2, stream_func_params.NextTree());

                    	    }
                    	    stream_func_params.Reset();

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    // MathExpr.g:200:97: ^( TYPE ( type )? )
                    	    {
                    	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
                    	    root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(TYPE, "TYPE"), root_2);

                    	    // MathExpr.g:200:104: ( type )?
                    	    if ( stream_type.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_2, stream_type.NextTree());

                    	    }
                    	    stream_type.Reset();

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 13 :
                    // MathExpr.g:201:3: RETURN ( returnValue | arrayValue )
                    {
                    	RETURN163=(IToken)Match(input,RETURN,FOLLOW_RETURN_in_expr1983); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RETURN.Add(RETURN163);

                    	// MathExpr.g:201:10: ( returnValue | arrayValue )
                    	int alt39 = 2;
                    	int LA39_0 = input.LA(1);

                    	if ( (LA39_0 == NOT || (LA39_0 >= TRUE && LA39_0 <= FALSE) || (LA39_0 >= NUMBER && LA39_0 <= IDENT) || (LA39_0 >= INCR && LA39_0 <= DECR) || LA39_0 == 74) )
                    	{
                    	    alt39 = 1;
                    	}
                    	else if ( (LA39_0 == 70) )
                    	{
                    	    alt39 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d39s0 =
                    	        new NoViableAltException("", 39, 0, input);

                    	    throw nvae_d39s0;
                    	}
                    	switch (alt39) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:201:11: returnValue
                    	        {
                    	        	PushFollow(FOLLOW_returnValue_in_expr1986);
                    	        	returnValue164 = returnValue();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_returnValue.Add(returnValue164.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // MathExpr.g:201:26: arrayValue
                    	        {
                    	        	PushFollow(FOLLOW_arrayValue_in_expr1991);
                    	        	arrayValue165 = arrayValue();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_arrayValue.Add(arrayValue165.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          returnValue, arrayValue, RETURN
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 201:38: -> ^( RETURN ( returnValue )? ( ^( ARRAY arrayValue ) )? )
                    	{
                    	    // MathExpr.g:201:41: ^( RETURN ( returnValue )? ( ^( ARRAY arrayValue ) )? )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_RETURN.NextNode(), root_1);

                    	    // MathExpr.g:201:50: ( returnValue )?
                    	    if ( stream_returnValue.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_returnValue.NextTree());

                    	    }
                    	    stream_returnValue.Reset();
                    	    // MathExpr.g:201:63: ( ^( ARRAY arrayValue ) )?
                    	    if ( stream_arrayValue.HasNext() )
                    	    {
                    	        // MathExpr.g:201:63: ^( ARRAY arrayValue )
                    	        {
                    	        AstNode root_2 = (AstNode)adaptor.GetNilNode();
                    	        root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(ARRAY, "ARRAY"), root_2);

                    	        adaptor.AddChild(root_2, stream_arrayValue.NextTree());

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_arrayValue.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 14 :
                    // MathExpr.g:202:3: SWITCH IDENT '{' ( swcase )* ( DEFAULT ':' expr )? '}'
                    {
                    	SWITCH166=(IToken)Match(input,SWITCH,FOLLOW_SWITCH_in_expr2012); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_SWITCH.Add(SWITCH166);

                    	IDENT167=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr2014); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT167);

                    	char_literal168=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_expr2016); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BEGIN.Add(char_literal168);

                    	// MathExpr.g:202:20: ( swcase )*
                    	do 
                    	{
                    	    int alt40 = 2;
                    	    int LA40_0 = input.LA(1);

                    	    if ( (LA40_0 == CASE) )
                    	    {
                    	        alt40 = 1;
                    	    }


                    	    switch (alt40) 
                    		{
                    			case 1 :
                    			    // MathExpr.g:202:21: swcase
                    			    {
                    			    	PushFollow(FOLLOW_swcase_in_expr2019);
                    			    	swcase169 = swcase();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_swcase.Add(swcase169.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop40;
                    	    }
                    	} while (true);

                    	loop40:
                    		;	// Stops C# compiler whining that label 'loop40' has no statements

                    	// MathExpr.g:202:30: ( DEFAULT ':' expr )?
                    	int alt41 = 2;
                    	int LA41_0 = input.LA(1);

                    	if ( (LA41_0 == DEFAULT) )
                    	{
                    	    alt41 = 1;
                    	}
                    	switch (alt41) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:202:31: DEFAULT ':' expr
                    	        {
                    	        	DEFAULT170=(IToken)Match(input,DEFAULT,FOLLOW_DEFAULT_in_expr2024); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_DEFAULT.Add(DEFAULT170);

                    	        	char_literal171=(IToken)Match(input,73,FOLLOW_73_in_expr2026); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_73.Add(char_literal171);

                    	        	PushFollow(FOLLOW_expr_in_expr2028);
                    	        	expr172 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_expr.Add(expr172.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal173=(IToken)Match(input,END,FOLLOW_END_in_expr2032); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_END.Add(char_literal173);



                    	// AST REWRITE
                    	// elements:          expr, SWITCH, swcase, DEFAULT, IDENT
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 202:54: -> ^( SWITCH IDENT ( swcase )* ( DEFAULT expr )? )
                    	{
                    	    // MathExpr.g:202:57: ^( SWITCH IDENT ( swcase )* ( DEFAULT expr )? )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot(stream_SWITCH.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
                    	    // MathExpr.g:202:73: ( swcase )*
                    	    while ( stream_swcase.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_swcase.NextTree());

                    	    }
                    	    stream_swcase.Reset();
                    	    // MathExpr.g:202:83: ( DEFAULT expr )?
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
            	Memoize(input, 24, expr_StartIndex); 
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
    // MathExpr.g:205:1: exprList : ( expr ( ( ';' )? exprList | ( ';' )* ) )? ;
    public MathExprParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MathExprParser.exprList_return retval = new MathExprParser.exprList_return();
        retval.Start = input.LT(1);
        int exprList_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal175 = null;
        IToken char_literal177 = null;
        MathExprParser.expr_return expr174 = default(MathExprParser.expr_return);

        MathExprParser.exprList_return exprList176 = default(MathExprParser.exprList_return);


        AstNode char_literal175_tree=null;
        AstNode char_literal177_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:205:9: ( ( expr ( ( ';' )? exprList | ( ';' )* ) )? )
            // MathExpr.g:205:11: ( expr ( ( ';' )? exprList | ( ';' )* ) )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	// MathExpr.g:205:11: ( expr ( ( ';' )? exprList | ( ';' )* ) )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == PRINT || LA46_0 == BEGIN || LA46_0 == IF || (LA46_0 >= WHILE && LA46_0 <= FOR) || LA46_0 == LET || LA46_0 == REPEATE || LA46_0 == VAR || (LA46_0 >= FUNC && LA46_0 <= SWITCH) || LA46_0 == IDENT || (LA46_0 >= INCR && LA46_0 <= DECR)) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // MathExpr.g:205:12: expr ( ( ';' )? exprList | ( ';' )* )
            	        {
            	        	PushFollow(FOLLOW_expr_in_exprList2063);
            	        	expr174 = expr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr174.Tree);
            	        	// MathExpr.g:205:17: ( ( ';' )? exprList | ( ';' )* )
            	        	int alt45 = 2;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case 77:
            	        		{
            	        	    int LA45_1 = input.LA(2);

            	        	    if ( (synpred79_MathExpr()) )
            	        	    {
            	        	        alt45 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt45 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        NoViableAltException nvae_d45s1 =
            	        	            new NoViableAltException("", 45, 1, input);

            	        	        throw nvae_d45s1;
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
            	        	    alt45 = 1;
            	        	    }
            	        	    break;
            	        	case END:
            	        		{
            	        	    int LA45_3 = input.LA(2);

            	        	    if ( (synpred79_MathExpr()) )
            	        	    {
            	        	        alt45 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt45 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        NoViableAltException nvae_d45s3 =
            	        	            new NoViableAltException("", 45, 3, input);

            	        	        throw nvae_d45s3;
            	        	    }
            	        	    }
            	        	    break;
            	        	case EOF:
            	        		{
            	        	    int LA45_4 = input.LA(2);

            	        	    if ( (synpred79_MathExpr()) )
            	        	    {
            	        	        alt45 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt45 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        NoViableAltException nvae_d45s4 =
            	        	            new NoViableAltException("", 45, 4, input);

            	        	        throw nvae_d45s4;
            	        	    }
            	        	    }
            	        	    break;
            	        		default:
            	        		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        		    NoViableAltException nvae_d45s0 =
            	        		        new NoViableAltException("", 45, 0, input);

            	        		    throw nvae_d45s0;
            	        	}

            	        	switch (alt45) 
            	        	{
            	        	    case 1 :
            	        	        // MathExpr.g:205:18: ( ';' )? exprList
            	        	        {
            	        	        	// MathExpr.g:205:18: ( ';' )?
            	        	        	int alt43 = 2;
            	        	        	int LA43_0 = input.LA(1);

            	        	        	if ( (LA43_0 == 77) )
            	        	        	{
            	        	        	    alt43 = 1;
            	        	        	}
            	        	        	switch (alt43) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // MathExpr.g:205:19: ';'
            	        	        	        {
            	        	        	        	char_literal175=(IToken)Match(input,77,FOLLOW_77_in_exprList2067); if (state.failed) return retval;

            	        	        	        }
            	        	        	        break;

            	        	        	}

            	        	        	PushFollow(FOLLOW_exprList_in_exprList2073);
            	        	        	exprList176 = exprList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList176.Tree);

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MathExpr.g:205:38: ( ';' )*
            	        	        {
            	        	        	// MathExpr.g:205:38: ( ';' )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt44 = 2;
            	        	        	    int LA44_0 = input.LA(1);

            	        	        	    if ( (LA44_0 == 77) )
            	        	        	    {
            	        	        	        alt44 = 1;
            	        	        	    }


            	        	        	    switch (alt44) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // MathExpr.g:205:39: ';'
            	        	        			    {
            	        	        			    	char_literal177=(IToken)Match(input,77,FOLLOW_77_in_exprList2078); if (state.failed) return retval;

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop44;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop44:
            	        	        		;	// Stops C# compiler whining that label 'loop44' has no statements


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
            	Memoize(input, 25, exprList_StartIndex); 
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
    // MathExpr.g:208:1: program : exprList ;
    public MathExprParser.program_return program() // throws RecognitionException [1]
    {   
        MathExprParser.program_return retval = new MathExprParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.exprList_return exprList178 = default(MathExprParser.exprList_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:208:8: ( exprList )
            // MathExpr.g:208:11: exprList
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_exprList_in_program2093);
            	exprList178 = exprList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList178.Tree);

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
            	Memoize(input, 26, program_StartIndex); 
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
    // MathExpr.g:212:8: public execute : program -> ^( PROGRAM program ) ;
    public MathExprParser.execute_return execute() // throws RecognitionException [1]
    {   
        MathExprParser.execute_return retval = new MathExprParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.program_return program179 = default(MathExprParser.program_return);


        RewriteRuleSubtreeStream stream_program = new RewriteRuleSubtreeStream(adaptor,"rule program");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:212:15: ( program -> ^( PROGRAM program ) )
            // MathExpr.g:213:5: program
            {
            	PushFollow(FOLLOW_program_in_execute2109);
            	program179 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program.Add(program179.Tree);


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
            	// 213:13: -> ^( PROGRAM program )
            	{
            	    // MathExpr.g:213:16: ^( PROGRAM program )
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
            	Memoize(input, 27, execute_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "execute"

    // $ANTLR start "synpred11_MathExpr"
    public void synpred11_MathExpr_fragment() {
        // MathExpr.g:126:14: ( term )
        // MathExpr.g:126:14: term
        {
        	PushFollow(FOLLOW_term_in_synpred11_MathExpr1112);
        	term();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_MathExpr"

    // $ANTLR start "synpred12_MathExpr"
    public void synpred12_MathExpr_fragment() {
        // MathExpr.g:126:21: ( value )
        // MathExpr.g:126:21: value
        {
        	PushFollow(FOLLOW_value_in_synpred12_MathExpr1116);
        	value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_MathExpr"

    // $ANTLR start "synpred17_MathExpr"
    public void synpred17_MathExpr_fragment() {
        // MathExpr.g:130:39: ( idar INCR )
        // MathExpr.g:130:39: idar INCR
        {
        	PushFollow(FOLLOW_idar_in_synpred17_MathExpr1191);
        	idar();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,INCR,FOLLOW_INCR_in_synpred17_MathExpr1193); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_MathExpr"

    // $ANTLR start "synpred30_MathExpr"
    public void synpred30_MathExpr_fragment() {
        // MathExpr.g:154:2: ( groupExpr )
        // MathExpr.g:154:2: groupExpr
        {
        	PushFollow(FOLLOW_groupExpr_in_synpred30_MathExpr1458);
        	groupExpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_MathExpr"

    // $ANTLR start "synpred49_MathExpr"
    public void synpred49_MathExpr_fragment() {
        // MathExpr.g:190:3: ( idar allassign term )
        // MathExpr.g:190:3: idar allassign term
        {
        	PushFollow(FOLLOW_idar_in_synpred49_MathExpr1680);
        	idar();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_allassign_in_synpred49_MathExpr1682);
        	allassign();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_term_in_synpred49_MathExpr1685);
        	term();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_MathExpr"

    // $ANTLR start "synpred50_MathExpr"
    public void synpred50_MathExpr_fragment() {
        // MathExpr.g:191:18: ( ELSE expr )
        // MathExpr.g:191:18: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred50_MathExpr1697); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred50_MathExpr1700);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred50_MathExpr"

    // $ANTLR start "synpred55_MathExpr"
    public void synpred55_MathExpr_fragment() {
        // MathExpr.g:193:52: ( groupExpr )
        // MathExpr.g:193:52: groupExpr
        {
        	PushFollow(FOLLOW_groupExpr_in_synpred55_MathExpr1739);
        	groupExpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred55_MathExpr"

    // $ANTLR start "synpred56_MathExpr"
    public void synpred56_MathExpr_fragment() {
        // MathExpr.g:193:3: ( FOR ( VAR IDENT ASSIGN term )? ';' ( compare )? ';' ( groupExpr )? expr )
        // MathExpr.g:193:3: FOR ( VAR IDENT ASSIGN term )? ';' ( compare )? ';' ( groupExpr )? expr
        {
        	Match(input,FOR,FOLLOW_FOR_in_synpred56_MathExpr1716); if (state.failed) return ;
        	// MathExpr.g:193:7: ( VAR IDENT ASSIGN term )?
        	int alt50 = 2;
        	int LA50_0 = input.LA(1);

        	if ( (LA50_0 == VAR) )
        	{
        	    alt50 = 1;
        	}
        	switch (alt50) 
        	{
        	    case 1 :
        	        // MathExpr.g:193:8: VAR IDENT ASSIGN term
        	        {
        	        	Match(input,VAR,FOLLOW_VAR_in_synpred56_MathExpr1719); if (state.failed) return ;
        	        	Match(input,IDENT,FOLLOW_IDENT_in_synpred56_MathExpr1721); if (state.failed) return ;
        	        	Match(input,ASSIGN,FOLLOW_ASSIGN_in_synpred56_MathExpr1723); if (state.failed) return ;
        	        	PushFollow(FOLLOW_term_in_synpred56_MathExpr1725);
        	        	term();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}

        	Match(input,77,FOLLOW_77_in_synpred56_MathExpr1730); if (state.failed) return ;
        	// MathExpr.g:193:37: ( compare )?
        	int alt51 = 2;
        	int LA51_0 = input.LA(1);

        	if ( (LA51_0 == NOT || (LA51_0 >= TRUE && LA51_0 <= FALSE) || (LA51_0 >= NUMBER && LA51_0 <= IDENT) || (LA51_0 >= INCR && LA51_0 <= DECR) || LA51_0 == 74) )
        	{
        	    alt51 = 1;
        	}
        	switch (alt51) 
        	{
        	    case 1 :
        	        // MathExpr.g:0:0: compare
        	        {
        	        	PushFollow(FOLLOW_compare_in_synpred56_MathExpr1732);
        	        	compare();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}

        	Match(input,77,FOLLOW_77_in_synpred56_MathExpr1735); if (state.failed) return ;
        	// MathExpr.g:193:50: ( groupExpr )?
        	int alt52 = 2;
        	alt52 = dfa52.Predict(input);
        	switch (alt52) 
        	{
        	    case 1 :
        	        // MathExpr.g:193:52: groupExpr
        	        {
        	        	PushFollow(FOLLOW_groupExpr_in_synpred56_MathExpr1739);
        	        	groupExpr();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}

        	PushFollow(FOLLOW_expr_in_synpred56_MathExpr1743);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred56_MathExpr"

    // $ANTLR start "synpred66_MathExpr"
    public void synpred66_MathExpr_fragment() {
        // MathExpr.g:196:3: ( FOR ( VAR )? IDENT IN term '...' term expr )
        // MathExpr.g:196:3: FOR ( VAR )? IDENT IN term '...' term expr
        {
        	Match(input,FOR,FOLLOW_FOR_in_synpred66_MathExpr1868); if (state.failed) return ;
        	// MathExpr.g:196:11: ( VAR )?
        	int alt61 = 2;
        	int LA61_0 = input.LA(1);

        	if ( (LA61_0 == VAR) )
        	{
        	    alt61 = 1;
        	}
        	switch (alt61) 
        	{
        	    case 1 :
        	        // MathExpr.g:0:0: VAR
        	        {
        	        	Match(input,VAR,FOLLOW_VAR_in_synpred66_MathExpr1871); if (state.failed) return ;

        	        }
        	        break;

        	}

        	Match(input,IDENT,FOLLOW_IDENT_in_synpred66_MathExpr1875); if (state.failed) return ;
        	Match(input,IN,FOLLOW_IN_in_synpred66_MathExpr1877); if (state.failed) return ;
        	PushFollow(FOLLOW_term_in_synpred66_MathExpr1880);
        	term();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,78,FOLLOW_78_in_synpred66_MathExpr1882); if (state.failed) return ;
        	PushFollow(FOLLOW_term_in_synpred66_MathExpr1885);
        	term();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred66_MathExpr1887);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred66_MathExpr"

    // $ANTLR start "synpred69_MathExpr"
    public void synpred69_MathExpr_fragment() {
        // MathExpr.g:198:3: ( groupExpr )
        // MathExpr.g:198:3: groupExpr
        {
        	PushFollow(FOLLOW_groupExpr_in_synpred69_MathExpr1912);
        	groupExpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred69_MathExpr"

    // $ANTLR start "synpred79_MathExpr"
    public void synpred79_MathExpr_fragment() {
        // MathExpr.g:205:18: ( ( ';' )? exprList )
        // MathExpr.g:205:18: ( ';' )? exprList
        {
        	// MathExpr.g:205:18: ( ';' )?
        	int alt66 = 2;
        	int LA66_0 = input.LA(1);

        	if ( (LA66_0 == 77) )
        	{
        	    alt66 = 1;
        	}
        	switch (alt66) 
        	{
        	    case 1 :
        	        // MathExpr.g:205:19: ';'
        	        {
        	        	Match(input,77,FOLLOW_77_in_synpred79_MathExpr2067); if (state.failed) return ;

        	        }
        	        break;

        	}

        	PushFollow(FOLLOW_exprList_in_synpred79_MathExpr2073);
        	exprList();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred79_MathExpr"

    // Delegated rules

   	public bool synpred30_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred30_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred49_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred49_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred17_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred50_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred50_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred69_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred69_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred56_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred56_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred79_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred79_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred12_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred55_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred55_MathExpr_fragment(); // can never throw exception
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
   	public bool synpred66_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred66_MathExpr_fragment(); // can never throw exception
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


   	protected DFA42 dfa42;
   	protected DFA28 dfa28;
   	protected DFA52 dfa52;
	private void InitializeCyclicDFAs()
	{
    	this.dfa42 = new DFA42(this);
    	this.dfa28 = new DFA28(this);
    	this.dfa52 = new DFA52(this);
	    this.dfa42.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA42_SpecialStateTransition);
	    this.dfa28.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA28_SpecialStateTransition);
	    this.dfa52.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA52_SpecialStateTransition);
	}

    const string DFA42_eotS =
        "\x12\uffff";
    const string DFA42_eofS =
        "\x12\uffff";
    const string DFA42_minS =
        "\x01\x05\x01\uffff\x01\x00\x02\uffff\x01\x00\x0c\uffff";
    const string DFA42_maxS =
        "\x01\x3b\x01\uffff\x01\x00\x02\uffff\x01\x00\x0c\uffff";
    const string DFA42_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\uffff\x01\x06"+
        "\x01\x07\x01\x09\x01\x0a\x01\uffff\x01\x0b\x01\x0c\x01\x0d\x01\x0e"+
        "\x01\x02\x01\x05\x01\x08";
    const string DFA42_specialS =
        "\x02\uffff\x01\x00\x02\uffff\x01\x01\x0c\uffff}>";
    static readonly string[] DFA42_transitionS = {
            "\x01\x08\x03\uffff\x01\x01\x01\uffff\x01\x03\x01\uffff\x01"+
            "\x04\x01\x05\x04\uffff\x01\x06\x01\uffff\x01\x0b\x04\uffff\x01"+
            "\x07\x04\uffff\x01\x0c\x01\x0d\x01\x0e\x12\uffff\x01\x02\x05"+
            "\uffff\x02\x09",
            "",
            "\x01\uffff",
            "",
            "",
            "\x01\uffff",
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
            ""
    };

    static readonly short[] DFA42_eot = DFA.UnpackEncodedString(DFA42_eotS);
    static readonly short[] DFA42_eof = DFA.UnpackEncodedString(DFA42_eofS);
    static readonly char[] DFA42_min = DFA.UnpackEncodedStringToUnsignedChars(DFA42_minS);
    static readonly char[] DFA42_max = DFA.UnpackEncodedStringToUnsignedChars(DFA42_maxS);
    static readonly short[] DFA42_accept = DFA.UnpackEncodedString(DFA42_acceptS);
    static readonly short[] DFA42_special = DFA.UnpackEncodedString(DFA42_specialS);
    static readonly short[][] DFA42_transition = DFA.UnpackEncodedStringArray(DFA42_transitionS);

    protected class DFA42 : DFA
    {
        public DFA42(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 42;
            this.eot = DFA42_eot;
            this.eof = DFA42_eof;
            this.min = DFA42_min;
            this.max = DFA42_max;
            this.accept = DFA42_accept;
            this.special = DFA42_special;
            this.transition = DFA42_transition;

        }

        override public string Description
        {
            get { return "188:1: expr : ( BEGIN exprList END -> ^( BLOCK ( exprList )? ) | idar allassign term | IF term expr ( ELSE expr )? | WHILE term expr | FOR ( VAR IDENT ASSIGN term )? ';' ( compare )? ';' ( groupExpr )? expr -> ^( FOR ( ^( VAR ^( IDENT TYPE ^( ASSIGN term ) ) ) )? ( compare )? ( groupExpr )? expr ) | LET idar ( ':' type )? ( ASSIGN returnValue )? ( ',' idar ( ':' type )? ( ASSIGN returnValue )? )* -> ^( LET ( ^( idar ^( TYPE ( type )? ) ( ^( ASSIGN returnValue ) )? ) )* ) | VAR var_element ( ',' var_element )* -> ^( VAR ( var_element )* ) | FOR ( VAR )? IDENT IN term '...' term expr | PRINT '(' ( STRINGVAL | idar ) ')' | groupExpr | REPEATE expr WHILE term -> ^( REPEATE term expr ) | FUNC IDENT '(' ( func_params )? ')' ( '->' type )? expr -> ^( FUNC IDENT ^( FUNC_PARAM ( func_params )? ) ^( TYPE ( type )? ) expr ) | RETURN ( returnValue | arrayValue ) -> ^( RETURN ( returnValue )? ( ^( ARRAY arrayValue ) )? ) | SWITCH IDENT '{' ( swcase )* ( DEFAULT ':' expr )? '}' -> ^( SWITCH IDENT ( swcase )* ( DEFAULT expr )? ) );"; }
        }

    }


    protected internal int DFA42_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA42_2 = input.LA(1);

                   	 
                   	int index42_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred49_MathExpr()) ) { s = 15; }

                   	else if ( (synpred69_MathExpr()) ) { s = 9; }

                   	 
                   	input.Seek(index42_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA42_5 = input.LA(1);

                   	 
                   	int index42_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred56_MathExpr()) ) { s = 16; }

                   	else if ( (synpred66_MathExpr()) ) { s = 17; }

                   	 
                   	input.Seek(index42_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae42 =
            new NoViableAltException(dfa.Description, 42, _s, input);
        dfa.Error(nvae42);
        throw nvae42;
    }
    const string DFA28_eotS =
        "\x10\uffff";
    const string DFA28_eofS =
        "\x10\uffff";
    const string DFA28_minS =
        "\x01\x05\x03\x00\x0c\uffff";
    const string DFA28_maxS =
        "\x01\x3b\x03\x00\x0c\uffff";
    const string DFA28_acceptS =
        "\x04\uffff\x01\x02\x0a\uffff\x01\x01";
    const string DFA28_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0c\uffff}>";
    static readonly string[] DFA28_transitionS = {
            "\x01\x04\x03\uffff\x01\x04\x01\uffff\x01\x04\x01\uffff\x02"+
            "\x04\x04\uffff\x01\x04\x01\uffff\x01\x04\x04\uffff\x01\x04\x04"+
            "\uffff\x03\x04\x12\uffff\x01\x01\x05\uffff\x01\x02\x01\x03",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
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
            ""
    };

    static readonly short[] DFA28_eot = DFA.UnpackEncodedString(DFA28_eotS);
    static readonly short[] DFA28_eof = DFA.UnpackEncodedString(DFA28_eofS);
    static readonly char[] DFA28_min = DFA.UnpackEncodedStringToUnsignedChars(DFA28_minS);
    static readonly char[] DFA28_max = DFA.UnpackEncodedStringToUnsignedChars(DFA28_maxS);
    static readonly short[] DFA28_accept = DFA.UnpackEncodedString(DFA28_acceptS);
    static readonly short[] DFA28_special = DFA.UnpackEncodedString(DFA28_specialS);
    static readonly short[][] DFA28_transition = DFA.UnpackEncodedStringArray(DFA28_transitionS);

    protected class DFA28 : DFA
    {
        public DFA28(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 28;
            this.eot = DFA28_eot;
            this.eof = DFA28_eof;
            this.min = DFA28_min;
            this.max = DFA28_max;
            this.accept = DFA28_accept;
            this.special = DFA28_special;
            this.transition = DFA28_transition;

        }

        override public string Description
        {
            get { return "193:50: ( groupExpr )?"; }
        }

    }


    protected internal int DFA28_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA28_1 = input.LA(1);

                   	 
                   	int index28_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred55_MathExpr()) ) { s = 15; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index28_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA28_2 = input.LA(1);

                   	 
                   	int index28_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred55_MathExpr()) ) { s = 15; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index28_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA28_3 = input.LA(1);

                   	 
                   	int index28_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred55_MathExpr()) ) { s = 15; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index28_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae28 =
            new NoViableAltException(dfa.Description, 28, _s, input);
        dfa.Error(nvae28);
        throw nvae28;
    }
    const string DFA52_eotS =
        "\x10\uffff";
    const string DFA52_eofS =
        "\x10\uffff";
    const string DFA52_minS =
        "\x01\x05\x03\x00\x0c\uffff";
    const string DFA52_maxS =
        "\x01\x3b\x03\x00\x0c\uffff";
    const string DFA52_acceptS =
        "\x04\uffff\x01\x02\x0a\uffff\x01\x01";
    const string DFA52_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0c\uffff}>";
    static readonly string[] DFA52_transitionS = {
            "\x01\x04\x03\uffff\x01\x04\x01\uffff\x01\x04\x01\uffff\x02"+
            "\x04\x04\uffff\x01\x04\x01\uffff\x01\x04\x04\uffff\x01\x04\x04"+
            "\uffff\x03\x04\x12\uffff\x01\x01\x05\uffff\x01\x02\x01\x03",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
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
            ""
    };

    static readonly short[] DFA52_eot = DFA.UnpackEncodedString(DFA52_eotS);
    static readonly short[] DFA52_eof = DFA.UnpackEncodedString(DFA52_eofS);
    static readonly char[] DFA52_min = DFA.UnpackEncodedStringToUnsignedChars(DFA52_minS);
    static readonly char[] DFA52_max = DFA.UnpackEncodedStringToUnsignedChars(DFA52_maxS);
    static readonly short[] DFA52_accept = DFA.UnpackEncodedString(DFA52_acceptS);
    static readonly short[] DFA52_special = DFA.UnpackEncodedString(DFA52_specialS);
    static readonly short[][] DFA52_transition = DFA.UnpackEncodedStringArray(DFA52_transitionS);

    protected class DFA52 : DFA
    {
        public DFA52(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 52;
            this.eot = DFA52_eot;
            this.eof = DFA52_eof;
            this.min = DFA52_min;
            this.max = DFA52_max;
            this.accept = DFA52_accept;
            this.special = DFA52_special;
            this.transition = DFA52_transition;

        }

        override public string Description
        {
            get { return "193:50: ( groupExpr )?"; }
        }

    }


    protected internal int DFA52_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA52_1 = input.LA(1);

                   	 
                   	int index52_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred55_MathExpr()) ) { s = 15; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index52_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA52_2 = input.LA(1);

                   	 
                   	int index52_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred55_MathExpr()) ) { s = 15; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index52_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA52_3 = input.LA(1);

                   	 
                   	int index52_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred55_MathExpr()) ) { s = 15; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index52_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae52 =
            new NoViableAltException(dfa.Description, 52, _s, input);
        dfa.Error(nvae52);
        throw nvae52;
    }
 

    public static readonly BitSet FOLLOW_IDENT_in_array835 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_array838 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_add_in_array840 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_array842 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_array_in_idar865 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_idar869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_type1051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_type1055 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_in_type1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_type1063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_in_type1067 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_70_in_type1072 = new BitSet(new ulong[]{0x0000000003D00000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_type_in_type1074 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_type1076 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_value0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_returnValue1112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_returnValue1116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_returnValue1120 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_70_in_arrayValue1127 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_returnValue_in_arrayValue1130 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_72_in_arrayValue1133 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_returnValue_in_arrayValue1136 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_71_in_arrayValue1140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_70_in_arrayValue1148 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_arrayValue_in_arrayValue1150 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_72_in_arrayValue1153 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_arrayValue_in_arrayValue1155 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_71_in_arrayValue1159 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCR_in_crement1177 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_idar_in_crement1179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_crement1191 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_INCR_in_crement1193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECR_in_crement1205 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_idar_in_crement1207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_crement1219 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_DECR_in_crement1221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_allassign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_swcase1262 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_returnValue_in_swcase1264 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_72_in_swcase1267 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_returnValue_in_swcase1269 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_73_in_swcase1273 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_swcase1275 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_returnValue_in_paramms1302 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_paramms1305 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_returnValue_in_paramms1307 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_params1326 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_func_params1328 = new BitSet(new ulong[]{0x0000000003D00000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_type_in_func_params1330 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_func_params1333 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_params1335 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_func_params1337 = new BitSet(new ulong[]{0x0000000003D00000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_type_in_func_params1339 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_call1358 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_74_in_func_call1360 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000C00UL});
    public static readonly BitSet FOLLOW_paramms_in_func_call1362 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_func_call1365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_var_element1384 = new BitSet(new ulong[]{0x0200000000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_var_element1387 = new BitSet(new ulong[]{0x0000000003D00000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_type_in_var_element1389 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_var_element1392 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_var_element1394 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_add_in_var_element1396 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_var_element1398 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_var_element1406 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000440UL});
    public static readonly BitSet FOLLOW_returnValue_in_var_element1410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayValue_in_var_element1414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupExpr_in_group1458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupInit_in_group1463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_groupInit1473 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_groupInit1476 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_groupInit1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_groupInit1483 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_groupInit1488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_array_in_groupInit1492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_groupExpr1501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_crement_in_groupExpr1507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_not1518 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_group_in_not1521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_not1525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_not_in_mult1533 = new BitSet(new ulong[]{0x0180000000000002UL});
    public static readonly BitSet FOLLOW_set_in_mult1537 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_not_in_mult1548 = new BitSet(new ulong[]{0x0180000000000002UL});
    public static readonly BitSet FOLLOW_mult_in_add1560 = new BitSet(new ulong[]{0x0060000000000002UL});
    public static readonly BitSet FOLLOW_set_in_add1565 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_mult_in_add1576 = new BitSet(new ulong[]{0x0060000000000002UL});
    public static readonly BitSet FOLLOW_or_logic_in_term1588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_compare1600 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_set_in_compare1603 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_add_in_compare1618 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_compare_in_and_logic1628 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_AND_in_and_logic1631 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_compare_in_and_logic1634 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_and_logic_in_or_logic1643 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_OR_in_or_logic1646 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_and_logic_in_or_logic1649 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_expr1663 = new BitSet(new ulong[]{0x0C10000384286E20UL});
    public static readonly BitSet FOLLOW_exprList_in_expr1665 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_END_in_expr1667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_expr1680 = new BitSet(new ulong[]{0xF200000000000000UL});
    public static readonly BitSet FOLLOW_allassign_in_expr1682 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_expr1685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr1689 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_expr1692 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1694 = new BitSet(new ulong[]{0x0000000000001002UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr1697 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr1706 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_expr1709 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr1716 = new BitSet(new ulong[]{0x0000000004000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_VAR_in_expr1719 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1721 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1723 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_expr1725 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_expr1730 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000002400UL});
    public static readonly BitSet FOLLOW_compare_in_expr1732 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_expr1735 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_groupExpr_in_expr1739 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1743 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LET_in_expr1778 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_idar_in_expr1780 = new BitSet(new ulong[]{0x0200000000000002UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_73_in_expr1783 = new BitSet(new ulong[]{0x0000000003D00000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_type_in_expr1785 = new BitSet(new ulong[]{0x0200000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1790 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_returnValue_in_expr1792 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_expr1797 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_idar_in_expr1799 = new BitSet(new ulong[]{0x0200000000000002UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_73_in_expr1802 = new BitSet(new ulong[]{0x0000000003D00000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_type_in_expr1804 = new BitSet(new ulong[]{0x0200000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1809 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_returnValue_in_expr1811 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_VAR_in_expr1846 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_var_element_in_expr1848 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_expr1851 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_var_element_in_expr1853 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_FOR_in_expr1868 = new BitSet(new ulong[]{0x0010000004000000UL});
    public static readonly BitSet FOLLOW_VAR_in_expr1871 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1875 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IN_in_expr1877 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_expr1880 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_expr1882 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_expr1885 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINT_in_expr1891 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_74_in_expr1894 = new BitSet(new ulong[]{0x0018000000000000UL});
    public static readonly BitSet FOLLOW_STRINGVAL_in_expr1899 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_idar_in_expr1903 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_expr1907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupExpr_in_expr1912 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REPEATE_in_expr1916 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1918 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr1920 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_expr1922 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNC_in_expr1936 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr1938 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_74_in_expr1940 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_func_params_in_expr1942 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_expr1945 = new BitSet(new ulong[]{0x0C10000384286A20UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_expr1948 = new BitSet(new ulong[]{0x0000000003D00000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_type_in_expr1950 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr1954 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_expr1983 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000440UL});
    public static readonly BitSet FOLLOW_returnValue_in_expr1986 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayValue_in_expr1991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SWITCH_in_expr2012 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr2014 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_BEGIN_in_expr2016 = new BitSet(new ulong[]{0x0000000C00000400UL});
    public static readonly BitSet FOLLOW_swcase_in_expr2019 = new BitSet(new ulong[]{0x0000000C00000400UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_expr2024 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_expr2026 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_expr2028 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_END_in_expr2032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_exprList2063 = new BitSet(new ulong[]{0x0C10000384286A20UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_exprList2067 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_exprList_in_exprList2073 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_exprList2078 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_exprList_in_program2093 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute2109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_synpred11_MathExpr1112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_synpred12_MathExpr1116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_synpred17_MathExpr1191 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_INCR_in_synpred17_MathExpr1193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupExpr_in_synpred30_MathExpr1458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idar_in_synpred49_MathExpr1680 = new BitSet(new ulong[]{0xF200000000000000UL});
    public static readonly BitSet FOLLOW_allassign_in_synpred49_MathExpr1682 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_synpred49_MathExpr1685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred50_MathExpr1697 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_synpred50_MathExpr1700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupExpr_in_synpred55_MathExpr1739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_synpred56_MathExpr1716 = new BitSet(new ulong[]{0x0000000004000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_VAR_in_synpred56_MathExpr1719 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_synpred56_MathExpr1721 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_synpred56_MathExpr1723 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_synpred56_MathExpr1725 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_synpred56_MathExpr1730 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000002400UL});
    public static readonly BitSet FOLLOW_compare_in_synpred56_MathExpr1732 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_synpred56_MathExpr1735 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_groupExpr_in_synpred56_MathExpr1739 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_synpred56_MathExpr1743 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_synpred66_MathExpr1868 = new BitSet(new ulong[]{0x0010000004000000UL});
    public static readonly BitSet FOLLOW_VAR_in_synpred66_MathExpr1871 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_synpred66_MathExpr1875 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IN_in_synpred66_MathExpr1877 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_synpred66_MathExpr1880 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_synpred66_MathExpr1882 = new BitSet(new ulong[]{0x0C1C018000020000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_term_in_synpred66_MathExpr1885 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_expr_in_synpred66_MathExpr1887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_groupExpr_in_synpred69_MathExpr1912 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_synpred79_MathExpr2067 = new BitSet(new ulong[]{0x0C10000384286A20UL});
    public static readonly BitSet FOLLOW_exprList_in_synpred79_MathExpr2073 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}