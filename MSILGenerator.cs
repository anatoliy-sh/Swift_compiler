using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Antlr.Runtime.Tree;

using AstNodeType = MathExpr.MathExprParser;


namespace MathExpr
{
    public class MSILGenerator
    {
        private ITree programNode = null;
        private Dictionary<string, int> vars = new Dictionary<string, int>();
        private StringBuilder msil = new StringBuilder();
        private int labIndex = 0;
        private static Context context;


        public MSILGenerator(ITree programNode)
        {
            if (programNode.Type != AstNodeType.PROGRAM)
                throw new MSILGeneratorException("AST-дерево не является программой");

            this.programNode = programNode;
        }


        private void NumVariables(ITree node)
        {
            switch (node.Type)
            {
                case AstNodeType.UNKNOWN:
                    throw new MSILGeneratorException("Неопределенный тип узла AST-дерева");

                case AstNodeType.IDENT:
                    string varName = node.Text;
                    if (!vars.ContainsKey(varName))
                        vars[varName] = vars.Count;
                    break;

                default:
                    for (int i = node.Type == AstNodeType.FUNC_CALL ? 1 : 0; i < node.ChildCount; i++)
                        NumVariables(node.GetChild(i));
                    break;
            }
        }

        private void NumVariables()
        {
            vars = new Dictionary<string, int>();
            NumVariables(programNode);
        }


        private void Generate(ITree node, Context context)
        {
            int tempLabIndex;

            switch (node.Type)
            {

                case AstNodeType.VARS:
                case AstNodeType.VAR:
                    int tmp = (node.GetChild(1) as AstNode).ODataType.ArrayCount;
                    if (tmp > 0)
                    {
                        for (int i = 0; i < tmp; i++)
                        {
                            msil.Append(string.Format("    ldc.i4.s {0}\n", (node.GetChild(1) as AstNode).ODataType.ALength));
                        }
                        if (tmp == 1)
                            msil.Append(string.Format("    newarr [mscorlib]System.{0}\n", ReturnConvertType(context.Idents[node.GetChild(0).Text].DataType.SimpleDataType)));
                        else
                        {
                            msil.Append(string.Format("    newobj instance void {0}", ReturnType(context.Idents[node.GetChild(0).Text].DataType.SimpleDataType)));
                            MsilArray(tmp);
                            msil.Append(string.Format("\n"));

                        }
                        msil.Append(string.Format("    stloc.s {0}\n", context.Idents[node.GetChild(0).Text].Index));
                    }
                    break;

                case AstNodeType.ARRAYPART:
                    Generate((AstNode)node.GetChild(0), context);
                    for (int i = 1; i < node.ChildCount; i++)
                    {
                        Generate((AstNode)node.GetChild(i), context);
                    }
                    if (node.ChildCount == 2)
                    {
                        msil.Append(string.Format("    ldelem.i4\n"));
                    }
                    else
                    {
                        string type = ReturnType(context.Idents[node.GetChild(0).Text].DataType.SimpleDataType);
                        msil.Append(string.Format("    call instance {0} {0} ", type));
                        MsilArray(node.ChildCount - 1);
                        msil.Append(string.Format("::Get({0} ", type));
                        for (int i = 0; i < node.ChildCount - 2; i++)
                        {
                            msil.Append(string.Format(",{0}", type));
                        }
                        msil.Append(string.Format(")\n", type));

                    }
                    break;

                case AstNodeType.ASSIGN:

                    if (node.GetChild(0).Type != AstNodeType.ARRAYPART)
                    {
                        Generate(node.GetChild(1), context);
                        msil.Append(string.Format("    stloc.s {0}\n", context.Idents[node.GetChild(0).Text].Index));
                    }
                    else
                    {
                        Generate(node.GetChild(0).GetChild(0), context);
                        for (int i = 1; i < node.ChildCount; i++)
                        {
                            Generate((AstNode)node.GetChild(0).GetChild(i), context);
                        }
                        if (node.ChildCount == 2)
                        {
                            Generate(node.GetChild(1), context);
                            msil.Append(string.Format("    stelem.i4\n"));
                        }
                        else
                        {
                            string type = ReturnType(context.Idents[node.GetChild(0).Text].DataType.SimpleDataType);
                            msil.Append(string.Format("    call instance void {0} ", type));
                            MsilArray(node.ChildCount - 1);
                            msil.Append(string.Format("::Set({0} ", type));
                            for (int i = 0; i < node.ChildCount - 2; i++)
                            {
                                msil.Append(string.Format(",{0}", type));
                            }
                            msil.Append(string.Format(")\n", type));

                        }
                    }
                    break;

                case AstNodeType.IDENT:
                    Ident ident = context.InThisContext(node.Text);//context.Idents[node.Text];
                    if (ident == null)
                    {
                        ident = context.ParentContext.InThisContext(node.Text);
                        if (ident != null && context.ParentContext.Function != null)
                            msil.Append(string.Format("    ldarg.s {0}\n", ident.Index));
                        break;
                    }
                        msil.Append(string.Format("    ldloc.s {0}\n", ident.Index));
                    break;

                case AstNodeType.NUMBER:
                    msil.Append(string.Format("    ldc.i4.s {0}\n", node.Text));
                    break;

                case AstNodeType.TRUE:
                    msil.Append(string.Format("    ldc.i4.s {0}\n", 1));
                    break;
                case AstNodeType.FALSE:
                    msil.Append(string.Format("    ldc.i4.s {0}\n", 0));
                    break;

                case AstNodeType.STRINGVAL:
                    msil.Append(string.Format("    ldstr {0}\n", node.Text));
                    break;



                case AstNodeType.FUNC_CALL:
                    for (int i = 0; i < node.GetChild(1).ChildCount; i++)
                    {
                        Generate(node.GetChild(1).GetChild(i), context);
                    }

                    msil.Append(string.Format("    call {0} Program::{1}(", ReturnType((node as AstNode).ODataType.SimpleDataType), node.GetChild(0).Text));
                    for (int i = 0; i < node.GetChild(1).ChildCount; i++)
                    {
                        msil.Append(string.Format("{0}, ", ReturnType((node.GetChild(1).GetChild(i) as AstNode).ODataType.SimpleDataType)));
                    }
                    msil.Remove(msil.Length - 2, 2);
                    msil.Append(string.Format(")\n"));
                    break;
                case AstNodeType.FUNC:
                    break;
                case AstNodeType.CONVERT:
                    Generate((AstNode)node.GetChild(0), context);
                    msil.Append(string.Format("    call string [mscorlib]System.Convert::To{0}({1})\n", ReturnConvertType((node as AstNode).ODataType.SimpleDataType),
                        ReturnType((node.GetChild(0) as AstNode).ODataType.SimpleDataType)));

                    break;

                case AstNodeType.ADD:
                case AstNodeType.SUB:
                case AstNodeType.MUL:
                case AstNodeType.DIV:
                    string oper = node.Type == AstNodeType.ADD ? "add" :
                                  node.Type == AstNodeType.SUB ? "sub" :
                                  node.Type == AstNodeType.MUL ? "mul" :
                                  node.Type == AstNodeType.DIV ? "div" :
                                  "unknown";

                    Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("    {0}\n", oper));
                    break;

                case AstNodeType.GT:
                case AstNodeType.EQ:
                case AstNodeType.LT:
                    oper = node.Type == AstNodeType.GT ? "cgt" :
                           node.Type == AstNodeType.LT ? "clt" :
                           node.Type == AstNodeType.EQ ? "ceq" :
                           "unknown";
                    Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("    {0}\n", oper));

                    break;

                case AstNodeType.GE:
                case AstNodeType.LE:
                case AstNodeType.NE:
                    oper = node.Type == AstNodeType.GE ? "clt" :
                           node.Type == AstNodeType.LE ? "cgt" :
                           node.Type == AstNodeType.NE ? "seq" :
                           "unknown";

                    Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("    {0}\n", oper));
                    msil.Append(string.Format("    ldc.i4.0 \n"));
                    msil.Append(string.Format("    seq\n"));
                    break;

                case MathExprLexer.SINCR:
                case MathExprLexer.EINCR:
                case MathExprLexer.SDECR:
                case MathExprLexer.EDECR:
                    oper = (node.Type == AstNodeType.SINCR || node.Type == AstNodeType.EINCR) ? "add" :
                           (node.Type == AstNodeType.SDECR || node.Type == AstNodeType.EDECR) ? "sub" :
                           "unknown";
                    msil.Append(string.Format("    ldloc.s {0}\n", context.Idents[node.GetChild(0).Text].Index));
                    msil.Append(string.Format("    ldc.i4.1 \n"));
                    msil.Append(string.Format("    {0}\n", oper));
                    msil.Append(string.Format("    stloc.s {0}\n", context.Idents[node.GetChild(0).Text].Index));
                    break;

                case AstNodeType.IF:
                    tempLabIndex = labIndex;
                    labIndex += 2;
                    Generate(node.GetChild(0), context);
                    msil.Append(string.Format("    brfalse.s L_{0:X4}\n", tempLabIndex + 1));
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("    br.s L_{0:X4}\n", tempLabIndex + 2));
                    msil.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    if (node.ChildCount > 2)
                        Generate(node.GetChild(2), context);
                    msil.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 2));
                    break;

                case AstNodeType.WHILE:
                    tempLabIndex = labIndex;
                    labIndex += 2;
                    msil.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    Generate(node.GetChild(0), context);
                    msil.Append(string.Format("    brfalse.s L_{0:X4}\n", tempLabIndex + 2));
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("    br.s L_{0:X4}\n", tempLabIndex + 1));
                    msil.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 2));
                    break;

                case AstNodeType.REPEATE:
                    tempLabIndex = labIndex;
                    labIndex += 1;
                    msil.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    Generate(node.GetChild(0), context);
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("    brtrue.s L_{0:X4}\n", tempLabIndex + 1));
                    break;

                case AstNodeType.FOR:
                    tempLabIndex = labIndex;
                    labIndex += 2;
                    Generate(node.GetChild(1), context);
                    msil.Append(string.Format("    stloc.s {0}\n", context.Idents[node.GetChild(0).GetChild(0).Text].Index));
                    msil.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    msil.Append(string.Format("    ldloc.s {0}\n", context.Idents[node.GetChild(0).GetChild(0).Text].Index));
                    Generate(node.GetChild(2), context);
                    msil.Append(string.Format("    sub\n"));
                    msil.Append(string.Format("    ldc.i4.s {0}\n", 1));
                    msil.Append(string.Format("    sub\n"));
                    msil.Append(string.Format("    brfalse.s L_{0:X4}\n", tempLabIndex + 2));
                    Generate(node.GetChild(3), context);
                    msil.Append(string.Format("    ldloc.s {0}\n", context.Idents[node.GetChild(0).GetChild(0).Text].Index));
                    msil.Append(string.Format("    ldc.i4.s {0}\n", 1));
                    msil.Append(string.Format("    add\n"));
                    msil.Append(string.Format("    stloc.s {0}\n", context.Idents[node.GetChild(0).GetChild(0).Text].Index));
                    msil.Append(string.Format("    br.s L_{0:X4}\n", tempLabIndex + 1));
                    msil.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 2));
                    break;

                case AstNodeType.PRINT:
                    Generate(node.GetChild(0), context);
                    msil.Append(string.Format("    call void [mscorlib]System.Console::WriteLine(string)\n"));
                    msil.Append(string.Format("    nop\n"));
                    break;

                case AstNodeType.RETURN:
                    Generate((AstNode)node.GetChild(0), context);
                    msil.Append(string.Format("    ret\n"));
                    break;
                case AstNodeType.BLOCK:
                case AstNodeType.PROGRAM:
                    for (int i = 0; i < node.ChildCount; i++)
                        Generate(node.GetChild(i), context);
                    break;

                default:
                    throw new MSILGeneratorException("Not implemented!");
            }
        }


        private void Generate()
        {
            msil = new StringBuilder();
            labIndex = 0;

            msil.Append(@"
.assembly extern mscorlib
{
    .ver 4:0:0:0
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
}
.assembly program
{
.custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
.custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78 63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )
.hash algorithm 0x00008004
.ver 0:0:0:0
}

.class public auto ansi beforefieldinit Program extends [mscorlib]System.Object
{

");
            int countFunc = 0;
            for (int i = 0; i < programNode.ChildCount; i++)
            {
                if ((programNode.GetChild(i) as AstNode).Type == AstNodeType.FUNC)
                    GenerateFunc((AstNode)programNode.GetChild(i), countFunc++);
            }
            msil.Append(@"
  .method public static void Main() cil managed
  {
    .entrypoint
");
            /*
            if (context.Idents.Count > 0)
            {
                msil.Append("    .locals init (\n");
                int index = 0;
                foreach (var kv in context.Idents)
                {
                    index++;
                    if (kv.Value.IdentType != IdentType.Function)
                    {
                        msil.Append(string.Format("      [{0}] {1}", kv.Value.Index, ReturnType(kv.Value.DataType.SimpleDataType)));
                        if (kv.Value.DataType.ArrayCount == 1)
                        {
                            msil.Append(string.Format("[]"));
                        }
                        else
                            if (kv.Value.DataType.ArrayCount > 1)
                            {
                                MsilArray(kv.Value.DataType.ArrayCount);
                            }

                        msil.Append(string.Format(" {0}{1}\n", kv.Key, index < context.Idents.Count ? "" : ""));
                    }
                }

                msil.Append("    )\n");
            }
            */
            fillInit(context);
            Generate(programNode, context);
            msil.Append(string.Format("    ret"));
            msil.Append(@"
  }
  .method public hidebysig specialname rtspecialname instance void 
          .ctor() cil managed
  {
    .maxstack  8
    ldarg.0
    call instance void [mscorlib]System.Object::.ctor()
    ret
  } 
}
");
        }

        private string ReturnType(DataType datatype)
        {
            switch (datatype)
            {
                case DataType.Int:
                    return "int32";
                case DataType.Bool:
                    return "bool";
                case DataType.String:
                    return "string";
                default:
                    return "void";
            }
        }
        private string ReturnConvertType(DataType datatype)
        {
            switch (datatype)
            {
                case DataType.Int:
                    return "Int32";
                case DataType.Bool:
                    return "Bool";
                case DataType.String:
                    return "String";
                default:
                    return "";
            }
        }
        private string ReturnTypeFromString(string datatype)
        {
            switch (datatype)
            {
                case "Int":
                    return "int32";
                case "Bool":
                    return "bool";
                case "String":
                    return "string";
                case "Double":
                    return "float64";
                default:
                    return "";
            }
        }

        private void MsilArray(int n)
        {
            msil.Append(string.Format("[0..."));
            for (int i = 1; i < n; i++)
            {
                msil.Append(string.Format(",0..."));
            }
            msil.Append(string.Format("]"));
        }

        public static string GenerateMSIL(ITree programNode, Context context1)
        {
            MSILGenerator g = new MSILGenerator(programNode);
            //g.NumVariables();
            context = context1;

            g.Generate();
            return g.msil.ToString();
        }

        private void GenerateFunc(AstNode node, int count)
        {
            Context tmpContext = SemanticChecker.contexts[count + 1];
            Context paramContext = SemanticChecker.contexts[count];
            int paramIndex = 0;
            foreach (var kv in paramContext.Idents)
            {
                if (kv.Value.IdentType != IdentType.Function)
                {
                    kv.Value.Index = paramIndex++;

                }
            }
            string returnType = ReturnTypeFromString((node.GetChild(2).GetChild(0) as AstNode).Text);
            msil.Append(string.Format("  .method public hidebysig static {0} {1}(", returnType, node.GetChild(0).Text));
            if (node.GetChild(1).ChildCount > 0)
            {
                msil.Append(string.Format("{0} {1}", ReturnTypeFromString(node.GetChild(1).GetChild(0).GetChild(0).Text), node.GetChild(1).GetChild(0).Text));
            }
            for (int i = 1; i < node.GetChild(1).ChildCount; i++)
            {
                msil.Append(string.Format(",{0} {1}", ReturnTypeFromString(node.GetChild(1).GetChild(i).GetChild(0).Text), node.GetChild(1).GetChild(i).Text));
            }
            msil.Append(string.Format(") cil managed\n"));
            msil.Append(@"  {
");
            fillInit(tmpContext);

            for (int i = 0; i < node.GetChild(3).ChildCount; i++)
            {
                Generate((AstNode)node.GetChild(3).GetChild(i), tmpContext);
            }
            msil.Append(string.Format("    ret"));
            msil.Append(@"  
  }");
        }
        public void fillInit(Context curContext)
        {
            if (curContext.Idents.Count > 0)
            {
                msil.Append("    .locals init (\n");
                int index = 0;
                foreach (var kv in curContext.Idents)
                {
                    if (kv.Value.IdentType != IdentType.Function)
                    {
                        msil.Append(string.Format("      [{0}] {1}", index, ReturnType(kv.Value.DataType.SimpleDataType))); //kv.Value.Index
                        kv.Value.Index = index;
                        if (kv.Value.DataType.ArrayCount == 1)
                        {
                            msil.Append(string.Format("[]"));
                        }
                        else
                            if (kv.Value.DataType.ArrayCount > 1)
                            {
                                MsilArray(kv.Value.DataType.ArrayCount);
                            }

                        msil.Append(string.Format(" {0}{1}\n", kv.Key, ++index < curContext.Idents.Count ? "," : ","));
                    }
                }
                msil.Remove(msil.Length - 2, 1);

                msil.Append("    )\n");
            }
        }
    }
}
