using System;
using System.Collections.Generic;
using System.Globalization;

using Antlr.Runtime.Tree;

using AstNodeType = MathLang.MathLangParser;
using AstNode = Antlr.Runtime.Tree.ITree;


namespace MathLang
{
  public class MathLangIntepreter
  {
    // "�������������������" ������ ��� ����� (� ������������ ������)
    public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
    // ����� ����������
    private static IDictionary<string, double> varTable = new Dictionary<string, double>();

    private AstNode programNode = null;


    public MathLangIntepreter(AstNode programNode) {
      if (programNode.Type != AstNodeType.PROGRAM)
        throw new IntepreterException("AST-������ �� �������� ����������");

      this.programNode = programNode;
    }


    private double ExecuteNode(AstNode node) {
      switch (node.Type) {
        case AstNodeType.UNKNOWN:
          throw new IntepreterException("�������������� ��� ���� AST-������");

        case AstNodeType.NUMBER:
          return double.Parse(node.Text, NFI);

        case AstNodeType.IDENT:
          if (varTable.ContainsKey(node.Text))
            return varTable[node.Text];
          else
            throw new ParserBaseException(string.Format("�������� {0} �� ����������", node.Text));

        case AstNodeType.ADD:
          return ExecuteNode(node.GetChild(0)) + ExecuteNode(node.GetChild(1));

        case AstNodeType.SUB:
          return ExecuteNode(node.GetChild(0)) - ExecuteNode(node.GetChild(1));

        case AstNodeType.MUL:
          return ExecuteNode(node.GetChild(0)) * ExecuteNode(node.GetChild(1));

        case AstNodeType.DIV:
          return ExecuteNode(node.GetChild(0)) / ExecuteNode(node.GetChild(1));

        case AstNodeType.ASSIGN:
          varTable[node.GetChild(0).Text] = ExecuteNode(node.GetChild(1));
          break;

        case AstNodeType.PRINT:
          Console.WriteLine(ExecuteNode(node.GetChild(0)).ToString(NFI));
          break;

        case AstNodeType.INPUT:
          Console.Write("input {0}: ", node.GetChild(0).Text);
          varTable[node.GetChild(0).Text] = double.Parse(Console.ReadLine(), NFI);
          break;

        case AstNodeType.BLOCK:
        case AstNodeType.PROGRAM:
          for (int i = 0; i < node.ChildCount; i++)
            ExecuteNode(node.GetChild(i));
          break;

        default:
          throw new IntepreterException("����������� ��� ���� AST-������");
      }

      return 0;
    }


    public void Execute() {
      ExecuteNode(programNode);
    }


    public static void Execute(AstNode programNode) {
      MathLangIntepreter mei=new MathLangIntepreter(programNode);
      mei.Execute();
    }
  }
}
