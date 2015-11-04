using System;
using System.Globalization;
using System.IO;

using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathExpr
{
  public class Program
  {
    // "культуронезависимый" формат для чисел (с разделителем точкой)
    public static readonly NumberFormatInfo NFI = new NumberFormatInfo();


    public static AstNode Check(string src, Context context)
    {
        ICharStream input = new ANTLRStringStream(src);
        MathExprLexer lexer = new MathExprLexer(input);
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        MathExprParser parser = new MathExprParser(tokens);
        parser.TreeAdaptor = new AstNodeTreeAdapter();
        AstNode program = (AstNode) parser.execute().Tree;
        SemanticChecker.Check((AstNode)program, context);
        return program;
    }


    public static void Main(string[] args) {
      try {
        // в зависимости от наличия параметров командной строки разбираем
        // либо файл с именем, переданным первым параметром, либо стандартный ввод
        Context context = new Context(null);
        string src = @"
            void printInt(int a) { }
            void printDouble(double a) { }
            double sqrt(double a) { }
            double sqr(double a) { }
            int readInt() { }
            double readDouble() { } 
        ";

        //Check(src, context);

        src = args.Length == 1 ? new StreamReader(args[0]).ReadToEnd()
                               : Console.In.ReadToEnd();
        ICharStream input = new ANTLRStringStream(src);
        MathExprLexer lexer = new MathExprLexer(input);
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        MathExprParser parser = new MathExprParser(tokens);
        parser.TreeAdaptor = new AstNodeTreeAdapter();
        ITree program = (ITree)parser.execute().Tree;
        AstNodePrinter.Print(program);
        Console.WriteLine();
        SemanticChecker.Check((AstNode) program, context);
        AstNodePrinter.Print(program);
        Console.ReadLine();

        AstNodePrinter.Print(program);
        Console.ReadLine();
      }
      catch (Exception e) {
        Console.WriteLine("Error: {0}", e);
        Console.ReadLine();
      }
    }
  }
}
