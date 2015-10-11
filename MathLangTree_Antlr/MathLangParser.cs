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


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "PRINT", "INPUT", "BLOCK", "PROGRAM", "BEGIN", "END", "IF", "THEN", "ELSE", "WHILE", "DO", "FOR", "TO", "DOWNTO", "AND", "OR", "NOT", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "IDENT", "ADD", "SUB", "MUL", "DIV", "ASSIGN", "GE", "LE", "EQ", "NE", "GT", "LT", "'('", "')'", "';'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MathLangParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MathLangParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MathLangParser.tokenNames; } }
	public override string GrammarFileName { get { return "MathLang.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class group_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_group();
	partial void Leave_group();

	// $ANTLR start "group"
	// MathLang.g:73:1: group : ( '(' term ')' | NUMBER | IDENT );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 1);
		TraceIn("group", 1);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal1=null;
		IToken char_literal3=null;
		IToken NUMBER4=null;
		IToken IDENT5=null;
		MathLangParser.term_return term2 = default(MathLangParser.term_return);

		object char_literal1_tree=null;
		object char_literal3_tree=null;
		object NUMBER4_tree=null;
		object IDENT5_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(73, 0);
		try
		{
			// MathLang.g:73:6: ( '(' term ')' | NUMBER | IDENT )
			int alt1=3;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 38:
				{
				alt1=1;
				}
				break;
			case NUMBER:
				{
				alt1=2;
				}
				break;
			case IDENT:
				{
				alt1=3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:74:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(74, 6);
				char_literal1=(IToken)Match(input,38,Follow._38_in_group634); 
				DebugLocation(74, 8);
				PushFollow(Follow._term_in_group637);
				term2=term();
				PopFollow();

				adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(74, 16);
				char_literal3=(IToken)Match(input,39,Follow._39_in_group639); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:75:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(75, 3);
				NUMBER4=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group644); 
				NUMBER4_tree = (object)adaptor.Create(NUMBER4);
				adaptor.AddChild(root_0, NUMBER4_tree);


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:76:3: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(76, 3);
				IDENT5=(IToken)Match(input,IDENT,Follow._IDENT_in_group648); 
				IDENT5_tree = (object)adaptor.Create(IDENT5);
				adaptor.AddChild(root_0, IDENT5_tree);


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("group", 1);
			LeaveRule("group", 1);
			Leave_group();
		}
		DebugLocation(77, 0);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"

	public class not_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_not();
	partial void Leave_not();

	// $ANTLR start "not"
	// MathLang.g:79:1: not : ( NOT group | group );
	[GrammarRule("not")]
	private MathLangParser.not_return not()
	{
		Enter_not();
		EnterRule("not", 2);
		TraceIn("not", 2);
		MathLangParser.not_return retval = new MathLangParser.not_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken NOT6=null;
		MathLangParser.group_return group7 = default(MathLangParser.group_return);
		MathLangParser.group_return group8 = default(MathLangParser.group_return);

		object NOT6_tree=null;

		try { DebugEnterRule(GrammarFileName, "not");
		DebugLocation(79, 0);
		try
		{
			// MathLang.g:79:4: ( NOT group | group )
			int alt2=2;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0==NOT))
			{
				alt2=1;
			}
			else if (((LA2_0>=NUMBER && LA2_0<=IDENT)||LA2_0==38))
			{
				alt2=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:80:3: NOT group
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 6);
				NOT6=(IToken)Match(input,NOT,Follow._NOT_in_not658); 
				NOT6_tree = (object)adaptor.Create(NOT6);
				root_0 = (object)adaptor.BecomeRoot(NOT6_tree, root_0);

				DebugLocation(80, 8);
				PushFollow(Follow._group_in_not661);
				group7=group();
				PopFollow();

				adaptor.AddChild(root_0, group7.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:81:3: group
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(81, 3);
				PushFollow(Follow._group_in_not665);
				group8=group();
				PopFollow();

				adaptor.AddChild(root_0, group8.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("not", 2);
			LeaveRule("not", 2);
			Leave_not();
		}
		DebugLocation(82, 0);
		} finally { DebugExitRule(GrammarFileName, "not"); }
		return retval;

	}
	// $ANTLR end "not"

	public class mult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mult();
	partial void Leave_mult();

	// $ANTLR start "mult"
	// MathLang.g:84:1: mult : not ( ( MUL | DIV ) not )* ;
	[GrammarRule("mult")]
	private MathLangParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 3);
		TraceIn("mult", 3);
		MathLangParser.mult_return retval = new MathLangParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set10=null;
		MathLangParser.not_return not9 = default(MathLangParser.not_return);
		MathLangParser.not_return not11 = default(MathLangParser.not_return);

		object set10_tree=null;

		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(84, 35);
		try
		{
			// MathLang.g:84:5: ( not ( ( MUL | DIV ) not )* )
			DebugEnterAlt(1);
			// MathLang.g:84:7: not ( ( MUL | DIV ) not )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 7);
			PushFollow(Follow._not_in_mult673);
			not9=not();
			PopFollow();

			adaptor.AddChild(root_0, not9.Tree);
			DebugLocation(84, 11);
			// MathLang.g:84:11: ( ( MUL | DIV ) not )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>=MUL && LA3_0<=DIV)))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:84:13: ( MUL | DIV ) not
					{
					DebugLocation(84, 13);
					set10=(IToken)input.LT(1);
					set10=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set10), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(84, 28);
					PushFollow(Follow._not_in_mult688);
					not11=not();
					PopFollow();

					adaptor.AddChild(root_0, not11.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 3);
			LeaveRule("mult", 3);
			Leave_mult();
		}
		DebugLocation(84, 35);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:85:1: add : mult ( ( ADD | SUB ) mult )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 4);
		TraceIn("add", 4);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set13=null;
		MathLangParser.mult_return mult12 = default(MathLangParser.mult_return);
		MathLangParser.mult_return mult14 = default(MathLangParser.mult_return);

		object set13_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(85, 39);
		try
		{
			// MathLang.g:85:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:85:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(85, 7);
			PushFollow(Follow._mult_in_add700);
			mult12=mult();
			PopFollow();

			adaptor.AddChild(root_0, mult12.Tree);
			DebugLocation(85, 13);
			// MathLang.g:85:13: ( ( ADD | SUB ) mult )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>=ADD && LA4_0<=SUB)))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:85:15: ( ADD | SUB ) mult
					{
					DebugLocation(85, 15);
					set13=(IToken)input.LT(1);
					set13=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set13), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(85, 30);
					PushFollow(Follow._mult_in_add716);
					mult14=mult();
					PopFollow();

					adaptor.AddChild(root_0, mult14.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 4);
			LeaveRule("add", 4);
			Leave_add();
		}
		DebugLocation(85, 39);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:86:1: term : or_logic ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 5);
		TraceIn("term", 5);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.or_logic_return or_logic15 = default(MathLangParser.or_logic_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(86, 16);
		try
		{
			// MathLang.g:86:5: ( or_logic )
			DebugEnterAlt(1);
			// MathLang.g:86:7: or_logic
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(86, 7);
			PushFollow(Follow._or_logic_in_term728);
			or_logic15=or_logic();
			PopFollow();

			adaptor.AddChild(root_0, or_logic15.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 5);
			LeaveRule("term", 5);
			Leave_term();
		}
		DebugLocation(86, 16);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class compare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_compare();
	partial void Leave_compare();

	// $ANTLR start "compare"
	// MathLang.g:88:1: compare : add ( ( GE | LE | EQ | NE | LT | GT ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 6);
		TraceIn("compare", 6);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set17=null;
		MathLangParser.add_return add16 = default(MathLangParser.add_return);
		MathLangParser.add_return add18 = default(MathLangParser.add_return);

		object set17_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(88, 0);
		try
		{
			// MathLang.g:88:8: ( add ( ( GE | LE | EQ | NE | LT | GT ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:89:3: add ( ( GE | LE | EQ | NE | LT | GT ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 3);
			PushFollow(Follow._add_in_compare740);
			add16=add();
			PopFollow();

			adaptor.AddChild(root_0, add16.Tree);
			DebugLocation(89, 7);
			// MathLang.g:89:7: ( ( GE | LE | EQ | NE | LT | GT ) add )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if (((LA5_0>=GE && LA5_0<=LT)))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:89:8: ( GE | LE | EQ | NE | LT | GT ) add
				{
				DebugLocation(89, 8);
				set17=(IToken)input.LT(1);
				set17=(IToken)input.LT(1);
				if ((input.LA(1)>=GE && input.LA(1)<=LT))
				{
					input.Consume();
					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set17), root_0);
					state.errorRecovery=false;
				}
				else
				{
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(89, 29);
				PushFollow(Follow._add_in_compare758);
				add18=add();
				PopFollow();

				adaptor.AddChild(root_0, add18.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("compare", 6);
			LeaveRule("compare", 6);
			Leave_compare();
		}
		DebugLocation(90, 0);
		} finally { DebugExitRule(GrammarFileName, "compare"); }
		return retval;

	}
	// $ANTLR end "compare"

	public class and_logic_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_and_logic();
	partial void Leave_and_logic();

	// $ANTLR start "and_logic"
	// MathLang.g:92:1: and_logic : compare ( AND compare )* ;
	[GrammarRule("and_logic")]
	private MathLangParser.and_logic_return and_logic()
	{
		Enter_and_logic();
		EnterRule("and_logic", 7);
		TraceIn("and_logic", 7);
		MathLangParser.and_logic_return retval = new MathLangParser.and_logic_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND20=null;
		MathLangParser.compare_return compare19 = default(MathLangParser.compare_return);
		MathLangParser.compare_return compare21 = default(MathLangParser.compare_return);

		object AND20_tree=null;

		try { DebugEnterRule(GrammarFileName, "and_logic");
		DebugLocation(92, 35);
		try
		{
			// MathLang.g:92:10: ( compare ( AND compare )* )
			DebugEnterAlt(1);
			// MathLang.g:92:12: compare ( AND compare )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 12);
			PushFollow(Follow._compare_in_and_logic768);
			compare19=compare();
			PopFollow();

			adaptor.AddChild(root_0, compare19.Tree);
			DebugLocation(92, 20);
			// MathLang.g:92:20: ( AND compare )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0==AND))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:92:21: AND compare
					{
					DebugLocation(92, 24);
					AND20=(IToken)Match(input,AND,Follow._AND_in_and_logic771); 
					AND20_tree = (object)adaptor.Create(AND20);
					root_0 = (object)adaptor.BecomeRoot(AND20_tree, root_0);

					DebugLocation(92, 26);
					PushFollow(Follow._compare_in_and_logic774);
					compare21=compare();
					PopFollow();

					adaptor.AddChild(root_0, compare21.Tree);

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("and_logic", 7);
			LeaveRule("and_logic", 7);
			Leave_and_logic();
		}
		DebugLocation(92, 35);
		} finally { DebugExitRule(GrammarFileName, "and_logic"); }
		return retval;

	}
	// $ANTLR end "and_logic"

	public class or_logic_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_or_logic();
	partial void Leave_or_logic();

	// $ANTLR start "or_logic"
	// MathLang.g:93:1: or_logic : and_logic ( OR and_logic )* ;
	[GrammarRule("or_logic")]
	private MathLangParser.or_logic_return or_logic()
	{
		Enter_or_logic();
		EnterRule("or_logic", 8);
		TraceIn("or_logic", 8);
		MathLangParser.or_logic_return retval = new MathLangParser.or_logic_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR23=null;
		MathLangParser.and_logic_return and_logic22 = default(MathLangParser.and_logic_return);
		MathLangParser.and_logic_return and_logic24 = default(MathLangParser.and_logic_return);

		object OR23_tree=null;

		try { DebugEnterRule(GrammarFileName, "or_logic");
		DebugLocation(93, 37);
		try
		{
			// MathLang.g:93:9: ( and_logic ( OR and_logic )* )
			DebugEnterAlt(1);
			// MathLang.g:93:11: and_logic ( OR and_logic )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 11);
			PushFollow(Follow._and_logic_in_or_logic783);
			and_logic22=and_logic();
			PopFollow();

			adaptor.AddChild(root_0, and_logic22.Tree);
			DebugLocation(93, 21);
			// MathLang.g:93:21: ( OR and_logic )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==OR))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:93:22: OR and_logic
					{
					DebugLocation(93, 24);
					OR23=(IToken)Match(input,OR,Follow._OR_in_or_logic786); 
					OR23_tree = (object)adaptor.Create(OR23);
					root_0 = (object)adaptor.BecomeRoot(OR23_tree, root_0);

					DebugLocation(93, 26);
					PushFollow(Follow._and_logic_in_or_logic789);
					and_logic24=and_logic();
					PopFollow();

					adaptor.AddChild(root_0, and_logic24.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("or_logic", 8);
			LeaveRule("or_logic", 8);
			Leave_or_logic();
		}
		DebugLocation(93, 37);
		} finally { DebugExitRule(GrammarFileName, "or_logic"); }
		return retval;

	}
	// $ANTLR end "or_logic"

	public class expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// MathLang.g:97:1: expr : ( BEGIN exprList END -> ^( BLOCK ( exprList )? ) | IDENT ASSIGN term | IF term THEN expr ( ELSE expr )? | WHILE term DO expr | FOR IDENT ASSIGN term ( TO | DOWNTO ) term DO expr );
	[GrammarRule("expr")]
	private MathLangParser.expr_return expr()
	{
		Enter_expr();
		EnterRule("expr", 9);
		TraceIn("expr", 9);
		MathLangParser.expr_return retval = new MathLangParser.expr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken BEGIN25=null;
		IToken END27=null;
		IToken IDENT28=null;
		IToken ASSIGN29=null;
		IToken IF31=null;
		IToken THEN33=null;
		IToken ELSE35=null;
		IToken WHILE37=null;
		IToken DO39=null;
		IToken FOR41=null;
		IToken IDENT42=null;
		IToken ASSIGN43=null;
		IToken set45=null;
		IToken DO47=null;
		MathLangParser.exprList_return exprList26 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term30 = default(MathLangParser.term_return);
		MathLangParser.term_return term32 = default(MathLangParser.term_return);
		MathLangParser.expr_return expr34 = default(MathLangParser.expr_return);
		MathLangParser.expr_return expr36 = default(MathLangParser.expr_return);
		MathLangParser.term_return term38 = default(MathLangParser.term_return);
		MathLangParser.expr_return expr40 = default(MathLangParser.expr_return);
		MathLangParser.term_return term44 = default(MathLangParser.term_return);
		MathLangParser.term_return term46 = default(MathLangParser.term_return);
		MathLangParser.expr_return expr48 = default(MathLangParser.expr_return);

		object BEGIN25_tree=null;
		object END27_tree=null;
		object IDENT28_tree=null;
		object ASSIGN29_tree=null;
		object IF31_tree=null;
		object THEN33_tree=null;
		object ELSE35_tree=null;
		object WHILE37_tree=null;
		object DO39_tree=null;
		object FOR41_tree=null;
		object IDENT42_tree=null;
		object ASSIGN43_tree=null;
		object set45_tree=null;
		object DO47_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(97, 0);
		try
		{
			// MathLang.g:97:5: ( BEGIN exprList END -> ^( BLOCK ( exprList )? ) | IDENT ASSIGN term | IF term THEN expr ( ELSE expr )? | WHILE term DO expr | FOR IDENT ASSIGN term ( TO | DOWNTO ) term DO expr )
			int alt9=5;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			switch (input.LA(1))
			{
			case BEGIN:
				{
				alt9=1;
				}
				break;
			case IDENT:
				{
				alt9=2;
				}
				break;
			case IF:
				{
				alt9=3;
				}
				break;
			case WHILE:
				{
				alt9=4;
				}
				break;
			case FOR:
				{
				alt9=5;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:98:3: BEGIN exprList END
				{
				DebugLocation(98, 3);
				BEGIN25=(IToken)Match(input,BEGIN,Follow._BEGIN_in_expr803);  
				stream_BEGIN.Add(BEGIN25);

				DebugLocation(98, 9);
				PushFollow(Follow._exprList_in_expr805);
				exprList26=exprList();
				PopFollow();

				stream_exprList.Add(exprList26.Tree);
				DebugLocation(98, 18);
				END27=(IToken)Match(input,END,Follow._END_in_expr807);  
				stream_END.Add(END27);



				{
				// AST REWRITE
				// elements: exprList
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 98:22: -> ^( BLOCK ( exprList )? )
				{
					DebugLocation(98, 25);
					// MathLang.g:98:25: ^( BLOCK ( exprList )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(98, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

					DebugLocation(98, 33);
					// MathLang.g:98:33: ( exprList )?
					if ( stream_exprList.HasNext )
					{
						DebugLocation(98, 33);
						adaptor.AddChild(root_1, stream_exprList.NextTree());

					}
					stream_exprList.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:99:3: IDENT ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(99, 3);
				IDENT28=(IToken)Match(input,IDENT,Follow._IDENT_in_expr820); 
				IDENT28_tree = (object)adaptor.Create(IDENT28);
				adaptor.AddChild(root_0, IDENT28_tree);

				DebugLocation(99, 15);
				ASSIGN29=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_expr822); 
				ASSIGN29_tree = (object)adaptor.Create(ASSIGN29);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN29_tree, root_0);

				DebugLocation(99, 17);
				PushFollow(Follow._term_in_expr825);
				term30=term();
				PopFollow();

				adaptor.AddChild(root_0, term30.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:100:3: IF term THEN expr ( ELSE expr )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(100, 5);
				IF31=(IToken)Match(input,IF,Follow._IF_in_expr829); 
				IF31_tree = (object)adaptor.Create(IF31);
				root_0 = (object)adaptor.BecomeRoot(IF31_tree, root_0);

				DebugLocation(100, 7);
				PushFollow(Follow._term_in_expr832);
				term32=term();
				PopFollow();

				adaptor.AddChild(root_0, term32.Tree);
				DebugLocation(100, 16);
				THEN33=(IToken)Match(input,THEN,Follow._THEN_in_expr834); 
				DebugLocation(100, 18);
				PushFollow(Follow._expr_in_expr837);
				expr34=expr();
				PopFollow();

				adaptor.AddChild(root_0, expr34.Tree);
				DebugLocation(100, 23);
				// MathLang.g:100:23: ( ELSE expr )?
				int alt8=2;
				try { DebugEnterSubRule(8);
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==ELSE))
				{
					alt8=1;
				}
				} finally { DebugExitDecision(8); }
				switch (alt8)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:100:24: ELSE expr
					{
					DebugLocation(100, 28);
					ELSE35=(IToken)Match(input,ELSE,Follow._ELSE_in_expr840); 
					DebugLocation(100, 30);
					PushFollow(Follow._expr_in_expr843);
					expr36=expr();
					PopFollow();

					adaptor.AddChild(root_0, expr36.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(8); }


				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:101:3: WHILE term DO expr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(101, 8);
				WHILE37=(IToken)Match(input,WHILE,Follow._WHILE_in_expr849); 
				WHILE37_tree = (object)adaptor.Create(WHILE37);
				root_0 = (object)adaptor.BecomeRoot(WHILE37_tree, root_0);

				DebugLocation(101, 10);
				PushFollow(Follow._term_in_expr852);
				term38=term();
				PopFollow();

				adaptor.AddChild(root_0, term38.Tree);
				DebugLocation(101, 17);
				DO39=(IToken)Match(input,DO,Follow._DO_in_expr854); 
				DebugLocation(101, 19);
				PushFollow(Follow._expr_in_expr857);
				expr40=expr();
				PopFollow();

				adaptor.AddChild(root_0, expr40.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:102:3: FOR IDENT ASSIGN term ( TO | DOWNTO ) term DO expr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(102, 6);
				FOR41=(IToken)Match(input,FOR,Follow._FOR_in_expr861); 
				FOR41_tree = (object)adaptor.Create(FOR41);
				root_0 = (object)adaptor.BecomeRoot(FOR41_tree, root_0);

				DebugLocation(102, 8);
				IDENT42=(IToken)Match(input,IDENT,Follow._IDENT_in_expr864); 
				IDENT42_tree = (object)adaptor.Create(IDENT42);
				adaptor.AddChild(root_0, IDENT42_tree);

				DebugLocation(102, 20);
				ASSIGN43=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_expr866); 
				DebugLocation(102, 22);
				PushFollow(Follow._term_in_expr869);
				term44=term();
				PopFollow();

				adaptor.AddChild(root_0, term44.Tree);
				DebugLocation(102, 27);
				set45=(IToken)input.LT(1);
				if ((input.LA(1)>=TO && input.LA(1)<=DOWNTO))
				{
					input.Consume();
					adaptor.AddChild(root_0, (object)adaptor.Create(set45));
					state.errorRecovery=false;
				}
				else
				{
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(102, 39);
				PushFollow(Follow._term_in_expr877);
				term46=term();
				PopFollow();

				adaptor.AddChild(root_0, term46.Tree);
				DebugLocation(102, 46);
				DO47=(IToken)Match(input,DO,Follow._DO_in_expr879); 
				DebugLocation(102, 48);
				PushFollow(Follow._expr_in_expr882);
				expr48=expr();
				PopFollow();

				adaptor.AddChild(root_0, expr48.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr", 9);
			LeaveRule("expr", 9);
			Leave_expr();
		}
		DebugLocation(103, 0);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return retval;

	}
	// $ANTLR end "expr"

	public class exprList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// MathLang.g:105:1: exprList : expr ( ( ';' )+ exprList | ( ';' )* ) ;
	[GrammarRule("exprList")]
	private MathLangParser.exprList_return exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 10);
		TraceIn("exprList", 10);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal50=null;
		IToken char_literal52=null;
		MathLangParser.expr_return expr49 = default(MathLangParser.expr_return);
		MathLangParser.exprList_return exprList51 = default(MathLangParser.exprList_return);

		object char_literal50_tree=null;
		object char_literal52_tree=null;

		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(105, 0);
		try
		{
			// MathLang.g:105:9: ( expr ( ( ';' )+ exprList | ( ';' )* ) )
			DebugEnterAlt(1);
			// MathLang.g:105:11: expr ( ( ';' )+ exprList | ( ';' )* )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 11);
			PushFollow(Follow._expr_in_exprList890);
			expr49=expr();
			PopFollow();

			adaptor.AddChild(root_0, expr49.Tree);
			DebugLocation(105, 16);
			// MathLang.g:105:16: ( ( ';' )+ exprList | ( ';' )* )
			int alt12=2;
			try { DebugEnterSubRule(12);
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			try
			{
				alt12 = dfa12.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:105:17: ( ';' )+ exprList
				{
				DebugLocation(105, 17);
				// MathLang.g:105:17: ( ';' )+
				int cnt10=0;
				try { DebugEnterSubRule(10);
				while (true)
				{
					int alt10=2;
					try { DebugEnterDecision(10, decisionCanBacktrack[10]);
					int LA10_0 = input.LA(1);

					if ((LA10_0==40))
					{
						alt10=1;
					}


					} finally { DebugExitDecision(10); }
					switch (alt10)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:105:18: ';'
						{
						DebugLocation(105, 21);
						char_literal50=(IToken)Match(input,40,Follow._40_in_exprList894); 

						}
						break;

					default:
						if (cnt10 >= 1)
							goto loop10;

						EarlyExitException eee10 = new EarlyExitException( 10, input );
						DebugRecognitionException(eee10);
						throw eee10;
					}
					cnt10++;
				}
				loop10:
					;

				} finally { DebugExitSubRule(10); }

				DebugLocation(105, 25);
				PushFollow(Follow._exprList_in_exprList899);
				exprList51=exprList();
				PopFollow();

				adaptor.AddChild(root_0, exprList51.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:105:36: ( ';' )*
				{
				DebugLocation(105, 36);
				// MathLang.g:105:36: ( ';' )*
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=2;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==40))
					{
						alt11=1;
					}


					} finally { DebugExitDecision(11); }
					switch ( alt11 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:105:37: ';'
						{
						DebugLocation(105, 40);
						char_literal52=(IToken)Match(input,40,Follow._40_in_exprList904); 

						}
						break;

					default:
						goto loop11;
					}
				}

				loop11:
					;

				} finally { DebugExitSubRule(11); }


				}
				break;

			}
			} finally { DebugExitSubRule(12); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("exprList", 10);
			LeaveRule("exprList", 10);
			Leave_exprList();
		}
		DebugLocation(106, 0);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return retval;

	}
	// $ANTLR end "exprList"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// MathLang.g:108:1: program : BEGIN exprList END ;
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 11);
		TraceIn("program", 11);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken BEGIN53=null;
		IToken END55=null;
		MathLangParser.exprList_return exprList54 = default(MathLangParser.exprList_return);

		object BEGIN53_tree=null;
		object END55_tree=null;

		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(108, 0);
		try
		{
			// MathLang.g:108:8: ( BEGIN exprList END )
			DebugEnterAlt(1);
			// MathLang.g:108:10: BEGIN exprList END
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 15);
			BEGIN53=(IToken)Match(input,BEGIN,Follow._BEGIN_in_program916); 
			DebugLocation(108, 17);
			PushFollow(Follow._exprList_in_program919);
			exprList54=exprList();
			PopFollow();

			adaptor.AddChild(root_0, exprList54.Tree);
			DebugLocation(108, 29);
			END55=(IToken)Match(input,END,Follow._END_in_program921); 

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 11);
			LeaveRule("program", 11);
			Leave_program();
		}
		DebugLocation(109, 0);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// MathLang.g:112:8: public execute : PROGRAM IDENT program ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 12);
		TraceIn("execute", 12);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROGRAM56=null;
		IToken IDENT57=null;
		MathLangParser.program_return program58 = default(MathLangParser.program_return);

		object PROGRAM56_tree=null;
		object IDENT57_tree=null;

		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(112, 0);
		try
		{
			// MathLang.g:112:15: ( PROGRAM IDENT program )
			DebugEnterAlt(1);
			// MathLang.g:113:3: PROGRAM IDENT program
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(113, 10);
			PROGRAM56=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_execute935); 
			DebugLocation(113, 17);
			IDENT57=(IToken)Match(input,IDENT,Follow._IDENT_in_execute938); 
			IDENT57_tree = (object)adaptor.Create(IDENT57);
			root_0 = (object)adaptor.BecomeRoot(IDENT57_tree, root_0);

			DebugLocation(113, 19);
			PushFollow(Follow._program_in_execute941);
			program58=program();
			PopFollow();

			adaptor.AddChild(root_0, program58.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 12);
			LeaveRule("execute", 12);
			Leave_execute();
		}
		DebugLocation(114, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"
	#endregion Rules


	#region DFA
	DFA12 dfa12;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa12 = new DFA12( this );
	}

	private class DFA12 : DFA
	{
		private const string DFA12_eotS =
			"\x4\xFFFF";
		private const string DFA12_eofS =
			"\x4\xFFFF";
		private const string DFA12_minS =
			"\x1\xA\x1\x9\x2\xFFFF";
		private const string DFA12_maxS =
			"\x2\x28\x2\xFFFF";
		private const string DFA12_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1";
		private const string DFA12_specialS =
			"\x4\xFFFF}>";
		private static readonly string[] DFA12_transitionS =
			{
				"\x1\x2\x1D\xFFFF\x1\x1",
				"\x1\x3\x1\x2\x1\x3\x2\xFFFF\x1\x3\x1\xFFFF\x1\x3\x9\xFFFF\x1\x3\xD"+
				"\xFFFF\x1\x1",
				"",
				""
			};

		private static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
		private static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
		private static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
		private static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
		private static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
		private static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
		private static readonly short[][] DFA12_transition;

		static DFA12()
		{
			int numStates = DFA12_transitionS.Length;
			DFA12_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA12_transition[i] = DFA.UnpackEncodedString(DFA12_transitionS[i]);
			}
		}

		public DFA12( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 12;
			this.eot = DFA12_eot;
			this.eof = DFA12_eof;
			this.min = DFA12_min;
			this.max = DFA12_max;
			this.accept = DFA12_accept;
			this.special = DFA12_special;
			this.transition = DFA12_transition;
		}

		public override string Description { get { return "105:16: ( ( ';' )+ exprList | ( ';' )* )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _38_in_group634 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _term_in_group637 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_group639 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group644 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group648 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOT_in_not658 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _group_in_not661 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_not665 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _not_in_mult673 = new BitSet(new ulong[]{0x60000002UL});
		public static readonly BitSet _set_in_mult677 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _not_in_mult688 = new BitSet(new ulong[]{0x60000002UL});
		public static readonly BitSet _mult_in_add700 = new BitSet(new ulong[]{0x18000002UL});
		public static readonly BitSet _set_in_add705 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _mult_in_add716 = new BitSet(new ulong[]{0x18000002UL});
		public static readonly BitSet _or_logic_in_term728 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _add_in_compare740 = new BitSet(new ulong[]{0x3F00000002UL});
		public static readonly BitSet _set_in_compare743 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _add_in_compare758 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_and_logic768 = new BitSet(new ulong[]{0x80002UL});
		public static readonly BitSet _AND_in_and_logic771 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _compare_in_and_logic774 = new BitSet(new ulong[]{0x80002UL});
		public static readonly BitSet _and_logic_in_or_logic783 = new BitSet(new ulong[]{0x100002UL});
		public static readonly BitSet _OR_in_or_logic786 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _and_logic_in_or_logic789 = new BitSet(new ulong[]{0x100002UL});
		public static readonly BitSet _BEGIN_in_expr803 = new BitSet(new ulong[]{0x4014A00UL});
		public static readonly BitSet _exprList_in_expr805 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _END_in_expr807 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_expr820 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _ASSIGN_in_expr822 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _term_in_expr825 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_expr829 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _term_in_expr832 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _THEN_in_expr834 = new BitSet(new ulong[]{0x4014A00UL});
		public static readonly BitSet _expr_in_expr837 = new BitSet(new ulong[]{0x2002UL});
		public static readonly BitSet _ELSE_in_expr840 = new BitSet(new ulong[]{0x4014A00UL});
		public static readonly BitSet _expr_in_expr843 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_expr849 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _term_in_expr852 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _DO_in_expr854 = new BitSet(new ulong[]{0x4014A00UL});
		public static readonly BitSet _expr_in_expr857 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_expr861 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _IDENT_in_expr864 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _ASSIGN_in_expr866 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _term_in_expr869 = new BitSet(new ulong[]{0x60000UL});
		public static readonly BitSet _set_in_expr871 = new BitSet(new ulong[]{0x4006200000UL});
		public static readonly BitSet _term_in_expr877 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _DO_in_expr879 = new BitSet(new ulong[]{0x4014A00UL});
		public static readonly BitSet _expr_in_expr882 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_exprList890 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _40_in_exprList894 = new BitSet(new ulong[]{0x10004014A00UL});
		public static readonly BitSet _exprList_in_exprList899 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _40_in_exprList904 = new BitSet(new ulong[]{0x10000000002UL});
		public static readonly BitSet _BEGIN_in_program916 = new BitSet(new ulong[]{0x4014A00UL});
		public static readonly BitSet _exprList_in_program919 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _END_in_program921 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PROGRAM_in_execute935 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _IDENT_in_execute938 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _program_in_execute941 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
