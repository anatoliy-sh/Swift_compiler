// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2015-10-11 13:10:20

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__38=38;
	public const int T__39=39;
	public const int T__40=40;
	public const int UNKNOWN=4;
	public const int PRINT=5;
	public const int INPUT=6;
	public const int BLOCK=7;
	public const int PROGRAM=8;
	public const int BEGIN=9;
	public const int END=10;
	public const int IF=11;
	public const int THEN=12;
	public const int ELSE=13;
	public const int WHILE=14;
	public const int DO=15;
	public const int FOR=16;
	public const int TO=17;
	public const int DOWNTO=18;
	public const int AND=19;
	public const int OR=20;
	public const int NOT=21;
	public const int WS=22;
	public const int SL_COMMENT=23;
	public const int ML_COMMENT=24;
	public const int NUMBER=25;
	public const int IDENT=26;
	public const int ADD=27;
	public const int SUB=28;
	public const int MUL=29;
	public const int DIV=30;
	public const int ASSIGN=31;
	public const int GE=32;
	public const int LE=33;
	public const int EQ=34;
	public const int NE=35;
	public const int GT=36;
	public const int LT=37;

    // delegates
    // delegators

	public MathLangLexer()
	{
		OnCreated();
	}

	public MathLangLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MathLangLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "MathLang.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_PRINT();
	partial void Leave_PRINT();

	// $ANTLR start "PRINT"
	[GrammarRule("PRINT")]
	private void mPRINT()
	{
		Enter_PRINT();
		EnterRule("PRINT", 1);
		TraceIn("PRINT", 1);
		try
		{
			int _type = PRINT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:9:7: ( 'print' )
			DebugEnterAlt(1);
			// MathLang.g:9:9: 'print'
			{
			DebugLocation(9, 9);
			Match("print"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PRINT", 1);
			LeaveRule("PRINT", 1);
			Leave_PRINT();
		}
	}
	// $ANTLR end "PRINT"

	partial void Enter_INPUT();
	partial void Leave_INPUT();

	// $ANTLR start "INPUT"
	[GrammarRule("INPUT")]
	private void mINPUT()
	{
		Enter_INPUT();
		EnterRule("INPUT", 2);
		TraceIn("INPUT", 2);
		try
		{
			int _type = INPUT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:10:7: ( 'input' )
			DebugEnterAlt(1);
			// MathLang.g:10:9: 'input'
			{
			DebugLocation(10, 9);
			Match("input"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INPUT", 2);
			LeaveRule("INPUT", 2);
			Leave_INPUT();
		}
	}
	// $ANTLR end "INPUT"

	partial void Enter_PROGRAM();
	partial void Leave_PROGRAM();

	// $ANTLR start "PROGRAM"
	[GrammarRule("PROGRAM")]
	private void mPROGRAM()
	{
		Enter_PROGRAM();
		EnterRule("PROGRAM", 3);
		TraceIn("PROGRAM", 3);
		try
		{
			int _type = PROGRAM;
			int _channel = DefaultTokenChannel;
			// MathLang.g:11:9: ( 'program' )
			DebugEnterAlt(1);
			// MathLang.g:11:11: 'program'
			{
			DebugLocation(11, 11);
			Match("program"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PROGRAM", 3);
			LeaveRule("PROGRAM", 3);
			Leave_PROGRAM();
		}
	}
	// $ANTLR end "PROGRAM"

	partial void Enter_BEGIN();
	partial void Leave_BEGIN();

	// $ANTLR start "BEGIN"
	[GrammarRule("BEGIN")]
	private void mBEGIN()
	{
		Enter_BEGIN();
		EnterRule("BEGIN", 4);
		TraceIn("BEGIN", 4);
		try
		{
			int _type = BEGIN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:7: ( 'begin' )
			DebugEnterAlt(1);
			// MathLang.g:12:9: 'begin'
			{
			DebugLocation(12, 9);
			Match("begin"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BEGIN", 4);
			LeaveRule("BEGIN", 4);
			Leave_BEGIN();
		}
	}
	// $ANTLR end "BEGIN"

	partial void Enter_END();
	partial void Leave_END();

	// $ANTLR start "END"
	[GrammarRule("END")]
	private void mEND()
	{
		Enter_END();
		EnterRule("END", 5);
		TraceIn("END", 5);
		try
		{
			int _type = END;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:5: ( 'end' )
			DebugEnterAlt(1);
			// MathLang.g:13:7: 'end'
			{
			DebugLocation(13, 7);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("END", 5);
			LeaveRule("END", 5);
			Leave_END();
		}
	}
	// $ANTLR end "END"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 6);
		TraceIn("IF", 6);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:4: ( 'if' )
			DebugEnterAlt(1);
			// MathLang.g:14:6: 'if'
			{
			DebugLocation(14, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 6);
			LeaveRule("IF", 6);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_THEN();
	partial void Leave_THEN();

	// $ANTLR start "THEN"
	[GrammarRule("THEN")]
	private void mTHEN()
	{
		Enter_THEN();
		EnterRule("THEN", 7);
		TraceIn("THEN", 7);
		try
		{
			int _type = THEN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:6: ( 'then' )
			DebugEnterAlt(1);
			// MathLang.g:15:8: 'then'
			{
			DebugLocation(15, 8);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THEN", 7);
			LeaveRule("THEN", 7);
			Leave_THEN();
		}
	}
	// $ANTLR end "THEN"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 8);
		TraceIn("ELSE", 8);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:6: ( 'else' )
			DebugEnterAlt(1);
			// MathLang.g:16:8: 'else'
			{
			DebugLocation(16, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 8);
			LeaveRule("ELSE", 8);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 9);
		TraceIn("WHILE", 9);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:7: ( 'while' )
			DebugEnterAlt(1);
			// MathLang.g:17:9: 'while'
			{
			DebugLocation(17, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 9);
			LeaveRule("WHILE", 9);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 10);
		TraceIn("DO", 10);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:4: ( 'do' )
			DebugEnterAlt(1);
			// MathLang.g:18:6: 'do'
			{
			DebugLocation(18, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 10);
			LeaveRule("DO", 10);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 11);
		TraceIn("FOR", 11);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:5: ( 'for' )
			DebugEnterAlt(1);
			// MathLang.g:19:7: 'for'
			{
			DebugLocation(19, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 11);
			LeaveRule("FOR", 11);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_TO();
	partial void Leave_TO();

	// $ANTLR start "TO"
	[GrammarRule("TO")]
	private void mTO()
	{
		Enter_TO();
		EnterRule("TO", 12);
		TraceIn("TO", 12);
		try
		{
			int _type = TO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:4: ( 'to' )
			DebugEnterAlt(1);
			// MathLang.g:20:6: 'to'
			{
			DebugLocation(20, 6);
			Match("to"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TO", 12);
			LeaveRule("TO", 12);
			Leave_TO();
		}
	}
	// $ANTLR end "TO"

	partial void Enter_DOWNTO();
	partial void Leave_DOWNTO();

	// $ANTLR start "DOWNTO"
	[GrammarRule("DOWNTO")]
	private void mDOWNTO()
	{
		Enter_DOWNTO();
		EnterRule("DOWNTO", 13);
		TraceIn("DOWNTO", 13);
		try
		{
			int _type = DOWNTO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:8: ( 'downto' )
			DebugEnterAlt(1);
			// MathLang.g:21:10: 'downto'
			{
			DebugLocation(21, 10);
			Match("downto"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOWNTO", 13);
			LeaveRule("DOWNTO", 13);
			Leave_DOWNTO();
		}
	}
	// $ANTLR end "DOWNTO"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 14);
		TraceIn("AND", 14);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:5: ( 'and' )
			DebugEnterAlt(1);
			// MathLang.g:22:7: 'and'
			{
			DebugLocation(22, 7);
			Match("and"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 14);
			LeaveRule("AND", 14);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 15);
		TraceIn("OR", 15);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:23:4: ( 'or' )
			DebugEnterAlt(1);
			// MathLang.g:23:6: 'or'
			{
			DebugLocation(23, 6);
			Match("or"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 15);
			LeaveRule("OR", 15);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_NOT();
	partial void Leave_NOT();

	// $ANTLR start "NOT"
	[GrammarRule("NOT")]
	private void mNOT()
	{
		Enter_NOT();
		EnterRule("NOT", 16);
		TraceIn("NOT", 16);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:24:5: ( 'not' )
			DebugEnterAlt(1);
			// MathLang.g:24:7: 'not'
			{
			DebugLocation(24, 7);
			Match("not"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 16);
			LeaveRule("NOT", 16);
			Leave_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void Enter_T__38();
	partial void Leave_T__38();

	// $ANTLR start "T__38"
	[GrammarRule("T__38")]
	private void mT__38()
	{
		Enter_T__38();
		EnterRule("T__38", 17);
		TraceIn("T__38", 17);
		try
		{
			int _type = T__38;
			int _channel = DefaultTokenChannel;
			// MathLang.g:25:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:25:9: '('
			{
			DebugLocation(25, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__38", 17);
			LeaveRule("T__38", 17);
			Leave_T__38();
		}
	}
	// $ANTLR end "T__38"

	partial void Enter_T__39();
	partial void Leave_T__39();

	// $ANTLR start "T__39"
	[GrammarRule("T__39")]
	private void mT__39()
	{
		Enter_T__39();
		EnterRule("T__39", 18);
		TraceIn("T__39", 18);
		try
		{
			int _type = T__39;
			int _channel = DefaultTokenChannel;
			// MathLang.g:26:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:26:9: ')'
			{
			DebugLocation(26, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__39", 18);
			LeaveRule("T__39", 18);
			Leave_T__39();
		}
	}
	// $ANTLR end "T__39"

	partial void Enter_T__40();
	partial void Leave_T__40();

	// $ANTLR start "T__40"
	[GrammarRule("T__40")]
	private void mT__40()
	{
		Enter_T__40();
		EnterRule("T__40", 19);
		TraceIn("T__40", 19);
		try
		{
			int _type = T__40;
			int _channel = DefaultTokenChannel;
			// MathLang.g:27:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:27:9: ';'
			{
			DebugLocation(27, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__40", 19);
			LeaveRule("T__40", 19);
			Leave_T__40();
		}
	}
	// $ANTLR end "T__40"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 20);
		TraceIn("WS", 20);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:36:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:37:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(37, 3);
			// MathLang.g:37:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='\t' && LA1_0<='\n')||(LA1_0>='\f' && LA1_0<='\r')||LA1_0==' '))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(37, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(37, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 20);
			LeaveRule("WS", 20);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 21);
		TraceIn("SL_COMMENT", 21);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:42:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:43:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(43, 3);
			Match("//"); 

			DebugLocation(43, 8);
			// MathLang.g:43:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='\r'))
				{
					alt2=2;
				}
				else if ((LA2_0=='\n'))
				{
					alt2=2;
				}
				else if (((LA2_0>='\u0000' && LA2_0<='\t')||(LA2_0>='\u000B' && LA2_0<='\f')||(LA2_0>='\u000E' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:43:36: .
					{
					DebugLocation(43, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(43, 40);
			// MathLang.g:43:40: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='\r'))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:43:40: '\\r'
				{
				DebugLocation(43, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(43, 46);
			Match('\n'); 
			DebugLocation(43, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 21);
			LeaveRule("SL_COMMENT", 21);
			Leave_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 22);
		TraceIn("ML_COMMENT", 22);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:47:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:48:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(48, 3);
			Match("/*"); 

			DebugLocation(48, 8);
			// MathLang.g:48:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='*'))
				{
					int LA4_1 = input.LA(2);

					if ((LA4_1=='/'))
					{
						alt4=2;
					}
					else if (((LA4_1>='\u0000' && LA4_1<='.')||(LA4_1>='0' && LA4_1<='\uFFFF')))
					{
						alt4=1;
					}


				}
				else if (((LA4_0>='\u0000' && LA4_0<=')')||(LA4_0>='+' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:48:36: .
					{
					DebugLocation(48, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(48, 40);
			Match("*/"); 

			DebugLocation(48, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 22);
			LeaveRule("ML_COMMENT", 22);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 23);
		TraceIn("NUMBER", 23);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:55:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
			DebugEnterAlt(1);
			// MathLang.g:55:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
			{
			DebugLocation(55, 9);
			// MathLang.g:55:9: ( '0' .. '9' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='0' && LA5_0<='9')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:55:10: '0' .. '9'
					{
					DebugLocation(55, 10);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(55, 21);
			// MathLang.g:55:21: ( '.' ( '0' .. '9' )+ )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='.'))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:55:22: '.' ( '0' .. '9' )+
				{
				DebugLocation(55, 22);
				Match('.'); 
				DebugLocation(55, 26);
				// MathLang.g:55:26: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if (((LA6_0>='0' && LA6_0<='9')))
					{
						alt6=1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:55:27: '0' .. '9'
						{
						DebugLocation(55, 27);
						MatchRange('0','9'); 

						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 23);
			LeaveRule("NUMBER", 23);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_IDENT();
	partial void Leave_IDENT();

	// $ANTLR start "IDENT"
	[GrammarRule("IDENT")]
	private void mIDENT()
	{
		Enter_IDENT();
		EnterRule("IDENT", 24);
		TraceIn("IDENT", 24);
		try
		{
			int _type = IDENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:57:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// MathLang.g:57:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(57, 9);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(58, 9);
			// MathLang.g:58:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>='0' && LA8_0<='9')||(LA8_0>='A' && LA8_0<='Z')||LA8_0=='_'||(LA8_0>='a' && LA8_0<='z')))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(58, 9);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IDENT", 24);
			LeaveRule("IDENT", 24);
			Leave_IDENT();
		}
	}
	// $ANTLR end "IDENT"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 25);
		TraceIn("ADD", 25);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:60:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:60:9: '+'
			{
			DebugLocation(60, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 25);
			LeaveRule("ADD", 25);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 26);
		TraceIn("SUB", 26);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:61:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:61:9: '-'
			{
			DebugLocation(61, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 26);
			LeaveRule("SUB", 26);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MUL();
	partial void Leave_MUL();

	// $ANTLR start "MUL"
	[GrammarRule("MUL")]
	private void mMUL()
	{
		Enter_MUL();
		EnterRule("MUL", 27);
		TraceIn("MUL", 27);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:62:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:62:9: '*'
			{
			DebugLocation(62, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 27);
			LeaveRule("MUL", 27);
			Leave_MUL();
		}
	}
	// $ANTLR end "MUL"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 28);
		TraceIn("DIV", 28);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:63:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:63:9: '/'
			{
			DebugLocation(63, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 28);
			LeaveRule("DIV", 28);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 29);
		TraceIn("ASSIGN", 29);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:64:7: ( ':=' )
			DebugEnterAlt(1);
			// MathLang.g:64:9: ':='
			{
			DebugLocation(64, 9);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 29);
			LeaveRule("ASSIGN", 29);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_GE();
	partial void Leave_GE();

	// $ANTLR start "GE"
	[GrammarRule("GE")]
	private void mGE()
	{
		Enter_GE();
		EnterRule("GE", 30);
		TraceIn("GE", 30);
		try
		{
			int _type = GE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:66:3: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:66:5: '>='
			{
			DebugLocation(66, 5);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GE", 30);
			LeaveRule("GE", 30);
			Leave_GE();
		}
	}
	// $ANTLR end "GE"

	partial void Enter_LE();
	partial void Leave_LE();

	// $ANTLR start "LE"
	[GrammarRule("LE")]
	private void mLE()
	{
		Enter_LE();
		EnterRule("LE", 31);
		TraceIn("LE", 31);
		try
		{
			int _type = LE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:67:3: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:67:5: '<='
			{
			DebugLocation(67, 5);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LE", 31);
			LeaveRule("LE", 31);
			Leave_LE();
		}
	}
	// $ANTLR end "LE"

	partial void Enter_EQ();
	partial void Leave_EQ();

	// $ANTLR start "EQ"
	[GrammarRule("EQ")]
	private void mEQ()
	{
		Enter_EQ();
		EnterRule("EQ", 32);
		TraceIn("EQ", 32);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:68:3: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:68:5: '='
			{
			DebugLocation(68, 5);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 32);
			LeaveRule("EQ", 32);
			Leave_EQ();
		}
	}
	// $ANTLR end "EQ"

	partial void Enter_NE();
	partial void Leave_NE();

	// $ANTLR start "NE"
	[GrammarRule("NE")]
	private void mNE()
	{
		Enter_NE();
		EnterRule("NE", 33);
		TraceIn("NE", 33);
		try
		{
			int _type = NE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:69:3: ( '<>' )
			DebugEnterAlt(1);
			// MathLang.g:69:5: '<>'
			{
			DebugLocation(69, 5);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NE", 33);
			LeaveRule("NE", 33);
			Leave_NE();
		}
	}
	// $ANTLR end "NE"

	partial void Enter_GT();
	partial void Leave_GT();

	// $ANTLR start "GT"
	[GrammarRule("GT")]
	private void mGT()
	{
		Enter_GT();
		EnterRule("GT", 34);
		TraceIn("GT", 34);
		try
		{
			int _type = GT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:70:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:70:5: '>'
			{
			DebugLocation(70, 5);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GT", 34);
			LeaveRule("GT", 34);
			Leave_GT();
		}
	}
	// $ANTLR end "GT"

	partial void Enter_LT();
	partial void Leave_LT();

	// $ANTLR start "LT"
	[GrammarRule("LT")]
	private void mLT()
	{
		Enter_LT();
		EnterRule("LT", 35);
		TraceIn("LT", 35);
		try
		{
			int _type = LT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:71:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:71:5: '<'
			{
			DebugLocation(71, 5);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LT", 35);
			LeaveRule("LT", 35);
			Leave_LT();
		}
	}
	// $ANTLR end "LT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PRINT | INPUT | PROGRAM | BEGIN | END | IF | THEN | ELSE | WHILE | DO | FOR | TO | DOWNTO | AND | OR | NOT | T__38 | T__39 | T__40 | WS | SL_COMMENT | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIV | ASSIGN | GE | LE | EQ | NE | GT | LT )
		int alt9=35;
		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
		try
		{
			alt9 = dfa9.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(9); }
		switch (alt9)
		{
		case 1:
			DebugEnterAlt(1);
			// MathLang.g:1:10: PRINT
			{
			DebugLocation(1, 10);
			mPRINT(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MathLang.g:1:16: INPUT
			{
			DebugLocation(1, 16);
			mINPUT(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MathLang.g:1:22: PROGRAM
			{
			DebugLocation(1, 22);
			mPROGRAM(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MathLang.g:1:30: BEGIN
			{
			DebugLocation(1, 30);
			mBEGIN(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:36: END
			{
			DebugLocation(1, 36);
			mEND(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:40: IF
			{
			DebugLocation(1, 40);
			mIF(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:43: THEN
			{
			DebugLocation(1, 43);
			mTHEN(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:48: ELSE
			{
			DebugLocation(1, 48);
			mELSE(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:53: WHILE
			{
			DebugLocation(1, 53);
			mWHILE(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:59: DO
			{
			DebugLocation(1, 59);
			mDO(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:62: FOR
			{
			DebugLocation(1, 62);
			mFOR(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:66: TO
			{
			DebugLocation(1, 66);
			mTO(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:69: DOWNTO
			{
			DebugLocation(1, 69);
			mDOWNTO(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:76: AND
			{
			DebugLocation(1, 76);
			mAND(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:80: OR
			{
			DebugLocation(1, 80);
			mOR(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:83: NOT
			{
			DebugLocation(1, 83);
			mNOT(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:87: T__38
			{
			DebugLocation(1, 87);
			mT__38(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:93: T__39
			{
			DebugLocation(1, 93);
			mT__39(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:99: T__40
			{
			DebugLocation(1, 99);
			mT__40(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:105: WS
			{
			DebugLocation(1, 105);
			mWS(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:108: SL_COMMENT
			{
			DebugLocation(1, 108);
			mSL_COMMENT(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:119: ML_COMMENT
			{
			DebugLocation(1, 119);
			mML_COMMENT(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:130: NUMBER
			{
			DebugLocation(1, 130);
			mNUMBER(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:137: IDENT
			{
			DebugLocation(1, 137);
			mIDENT(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:143: ADD
			{
			DebugLocation(1, 143);
			mADD(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:147: SUB
			{
			DebugLocation(1, 147);
			mSUB(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:151: MUL
			{
			DebugLocation(1, 151);
			mMUL(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:155: DIV
			{
			DebugLocation(1, 155);
			mDIV(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:159: ASSIGN
			{
			DebugLocation(1, 159);
			mASSIGN(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:166: GE
			{
			DebugLocation(1, 166);
			mGE(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:169: LE
			{
			DebugLocation(1, 169);
			mLE(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:172: EQ
			{
			DebugLocation(1, 172);
			mEQ(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:175: NE
			{
			DebugLocation(1, 175);
			mNE(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:178: GT
			{
			DebugLocation(1, 178);
			mGT(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:181: LT
			{
			DebugLocation(1, 181);
			mLT(); 

			}
			break;

		}

	}


	#region DFA
	DFA9 dfa9;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa9 = new DFA9(this);
	}

	private class DFA9 : DFA
	{
		private const string DFA9_eotS =
			"\x1\xFFFF\xB\x12\x4\xFFFF\x1\x2A\x6\xFFFF\x1\x2C\x1\x2F\x1\xFFFF\x2"+
			"\x12\x1\x33\x4\x12\x1\x38\x1\x12\x1\x3B\x2\x12\x1\x3E\x1\x12\x8\xFFFF"+
			"\x3\x12\x1\xFFFF\x1\x12\x1\x44\x2\x12\x1\xFFFF\x2\x12\x1\xFFFF\x1\x49"+
			"\x1\x4A\x1\xFFFF\x1\x4B\x4\x12\x1\xFFFF\x1\x50\x1\x51\x2\x12\x3\xFFFF"+
			"\x1\x54\x1\x12\x1\x56\x1\x57\x2\xFFFF\x1\x58\x1\x12\x1\xFFFF\x1\x12\x3"+
			"\xFFFF\x1\x5B\x1\x5C\x2\xFFFF";
		private const string DFA9_eofS =
			"\x5D\xFFFF";
		private const string DFA9_minS =
			"\x1\x9\x1\x72\x1\x66\x1\x65\x1\x6C\x2\x68\x2\x6F\x1\x6E\x1\x72\x1\x6F"+
			"\x4\xFFFF\x1\x2A\x6\xFFFF\x2\x3D\x1\xFFFF\x1\x69\x1\x70\x1\x30\x1\x67"+
			"\x1\x64\x1\x73\x1\x65\x1\x30\x1\x69\x1\x30\x1\x72\x1\x64\x1\x30\x1\x74"+
			"\x8\xFFFF\x1\x6E\x1\x67\x1\x75\x1\xFFFF\x1\x69\x1\x30\x1\x65\x1\x6E\x1"+
			"\xFFFF\x1\x6C\x1\x6E\x1\xFFFF\x2\x30\x1\xFFFF\x1\x30\x1\x74\x1\x72\x1"+
			"\x74\x1\x6E\x1\xFFFF\x2\x30\x1\x65\x1\x74\x3\xFFFF\x1\x30\x1\x61\x2\x30"+
			"\x2\xFFFF\x1\x30\x1\x6F\x1\xFFFF\x1\x6D\x3\xFFFF\x2\x30\x2\xFFFF";
		private const string DFA9_maxS =
			"\x1\x7A\x1\x72\x1\x6E\x1\x65\x1\x6E\x1\x6F\x1\x68\x2\x6F\x1\x6E\x1\x72"+
			"\x1\x6F\x4\xFFFF\x1\x2F\x6\xFFFF\x1\x3D\x1\x3E\x1\xFFFF\x1\x6F\x1\x70"+
			"\x1\x7A\x1\x67\x1\x64\x1\x73\x1\x65\x1\x7A\x1\x69\x1\x7A\x1\x72\x1\x64"+
			"\x1\x7A\x1\x74\x8\xFFFF\x1\x6E\x1\x67\x1\x75\x1\xFFFF\x1\x69\x1\x7A\x1"+
			"\x65\x1\x6E\x1\xFFFF\x1\x6C\x1\x6E\x1\xFFFF\x2\x7A\x1\xFFFF\x1\x7A\x1"+
			"\x74\x1\x72\x1\x74\x1\x6E\x1\xFFFF\x2\x7A\x1\x65\x1\x74\x3\xFFFF\x1\x7A"+
			"\x1\x61\x2\x7A\x2\xFFFF\x1\x7A\x1\x6F\x1\xFFFF\x1\x6D\x3\xFFFF\x2\x7A"+
			"\x2\xFFFF";
		private const string DFA9_acceptS =
			"\xC\xFFFF\x1\x11\x1\x12\x1\x13\x1\x14\x1\xFFFF\x1\x17\x1\x18\x1\x19"+
			"\x1\x1A\x1\x1B\x1\x1D\x2\xFFFF\x1\x20\xE\xFFFF\x1\x15\x1\x16\x1\x1C\x1"+
			"\x1E\x1\x22\x1\x1F\x1\x21\x1\x23\x3\xFFFF\x1\x6\x4\xFFFF\x1\xC\x2\xFFFF"+
			"\x1\xA\x2\xFFFF\x1\xF\x5\xFFFF\x1\x5\x4\xFFFF\x1\xB\x1\xE\x1\x10\x4\xFFFF"+
			"\x1\x8\x1\x7\x2\xFFFF\x1\x1\x1\xFFFF\x1\x2\x1\x4\x1\x9\x2\xFFFF\x1\xD"+
			"\x1\x3";
		private const string DFA9_specialS =
			"\x5D\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x2\xF\x1\xFFFF\x2\xF\x12\xFFFF\x1\xF\x7\xFFFF\x1\xC\x1\xD\x1\x15\x1"+
				"\x13\x1\xFFFF\x1\x14\x1\xFFFF\x1\x10\xA\x11\x1\x16\x1\xE\x1\x18\x1\x19"+
				"\x1\x17\x2\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1\x9\x1\x3\x1\x12"+
				"\x1\x7\x1\x4\x1\x8\x2\x12\x1\x2\x4\x12\x1\xB\x1\xA\x1\x1\x3\x12\x1\x5"+
				"\x2\x12\x1\x6\x3\x12",
				"\x1\x1A",
				"\x1\x1C\x7\xFFFF\x1\x1B",
				"\x1\x1D",
				"\x1\x1F\x1\xFFFF\x1\x1E",
				"\x1\x20\x6\xFFFF\x1\x21",
				"\x1\x22",
				"\x1\x23",
				"\x1\x24",
				"\x1\x25",
				"\x1\x26",
				"\x1\x27",
				"",
				"",
				"",
				"",
				"\x1\x29\x4\xFFFF\x1\x28",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2B",
				"\x1\x2D\x1\x2E",
				"",
				"\x1\x30\x5\xFFFF\x1\x31",
				"\x1\x32",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\x1\x34",
				"\x1\x35",
				"\x1\x36",
				"\x1\x37",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\x1\x39",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x16\x12\x1\x3A\x3"+
				"\x12",
				"\x1\x3C",
				"\x1\x3D",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\x1\x3F",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x40",
				"\x1\x41",
				"\x1\x42",
				"",
				"\x1\x43",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\x1\x45",
				"\x1\x46",
				"",
				"\x1\x47",
				"\x1\x48",
				"",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\x1\x4C",
				"\x1\x4D",
				"\x1\x4E",
				"\x1\x4F",
				"",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\x1\x52",
				"\x1\x53",
				"",
				"",
				"",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\x1\x55",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"",
				"",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\x1\x59",
				"",
				"\x1\x5A",
				"",
				"",
				"",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x7\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1A\x12",
				"",
				""
			};

		private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
		private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
		private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
		private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
		private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
		private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
		private static readonly short[][] DFA9_transition;

		static DFA9()
		{
			int numStates = DFA9_transitionS.Length;
			DFA9_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
			}
		}

		public DFA9( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 9;
			this.eot = DFA9_eot;
			this.eof = DFA9_eof;
			this.min = DFA9_min;
			this.max = DFA9_max;
			this.accept = DFA9_accept;
			this.special = DFA9_special;
			this.transition = DFA9_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( PRINT | INPUT | PROGRAM | BEGIN | END | IF | THEN | ELSE | WHILE | DO | FOR | TO | DOWNTO | AND | OR | NOT | T__38 | T__39 | T__40 | WS | SL_COMMENT | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIV | ASSIGN | GE | LE | EQ | NE | GT | LT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 
