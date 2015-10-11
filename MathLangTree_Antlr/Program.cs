using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathLang
{
  public class Program
  {
    // "�������������������" ������ ��� ����� (� ������������ ������)
    public static readonly NumberFormatInfo NFI = new NumberFormatInfo();


    public static void Main(string[] args) {
      try {
        // � ����������� �� ������� ���������� ��������� ������ ���������
        // ���� ���� � ������, ���������� ������ ����������, ���� ����������� ����
        ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                             : (ICharStream)new ANTLRReaderStream(Console.In);
        MathLangLexer lexer = new MathLangLexer(input);
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        MathLangParser parser = new MathLangParser(tokens);
        ITree program = (ITree)parser.execute().Tree;
        AstNodePrinter.Print(program);
       // Console.WriteLine();
       // MathLangIntepreter.Execute(program);
      }
      catch (Exception e) {
        Console.WriteLine("Error: {0}", e);
      }
      Console.ReadLine();
    }
  }
}
