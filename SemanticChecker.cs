using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpr
{
    public enum IdentType
    {
        GlobalVar,
        LocalVar,
        Param,
        Function
    }

    public enum DataType
    {
        Void,
        Int,
        Double,
        Bool,
        String,
        Array
    }

    public class Ident
    {
        public string Name { get; set; }
        public IdentType IdentType { get; set; }
        public OrigDataType DataType { get; set; }
        public int Index { get; set; }
        public AstNode Node { get; set; }


        public Ident(string name, IdentType identType, OrigDataType dataType, AstNode node, int index)
        {
            Name = name;
            IdentType = identType;
            DataType = dataType;
            Node = node;
            Index = index;
        }
    }


    public class Context
    {
        private Context parentContext;

        private Dictionary<string, Ident> idents = new Dictionary<string, Ident>();

        public Context(Context parentContext)
        {
            this.parentContext = parentContext;
        }

        public Ident this[string name]
        {
            get
            {
                return idents.ContainsKey(name) ? idents[name] :
                           parentContext != null ? parentContext[name] : null;
            }
            set
            {
                idents[name] = value;
            }
        }

        public Ident InThisContext(string name)
        {
            return idents.ContainsKey(name) ? idents[name] : null;
        }

        public Dictionary<string, Ident> Idents
        {
            get
            {
                return idents;
            }
            set { }
        }

        private Ident function = null;

        public Ident Function
        {
            get
            {
                return function != null ? function :
                           parentContext != null ? parentContext.Function : null;
            }
            set
            {
                function = value;
            }
        }

        public Context ParentContext
        {
            get
            {
                return parentContext;
            }
        }
    }


    public class SemanticChecker
    {
        private static int identIndex = 0;
        public static List<Context> contexts = new List<Context>();

        public static DataType strToDataType(string type)
        {
            switch (type)
            {
                case "Int":
                    return DataType.Int;
                case "Double":
                    return DataType.Double;
                case "Boolean":
                    return DataType.Bool;
                case "String":
                    return DataType.String;
                case "ARRAY":
                    return DataType.Array;
                case "Void":

                case "":
                    return DataType.Void;
                default:
                    throw new ApplicationException("Invalid data type");
            }
        }

        public static string dataTypeToStr(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Int:
                    return "Int";
                case DataType.Double:
                    return "Double";
                case DataType.Bool:
                    return "Boolean";
                case DataType.Void:
                    return "Void";
                case DataType.String:
                    return "String";
                case DataType.Array:
                    return "ARRAY";
                default:
                    return "unknown";
            }
        }

        private static void convert(AstNode node, OrigDataType dataType)
        {
            AstNode convert = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.CONVERT, "CONVERT"));
            node.Parent.SetChild(node.ChildIndex, convert);
            convert.ODataType = dataType;
            convert.AddChild(node);
            convert.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.IDENT, dataTypeToStr(dataType.SimpleDataType))));
        }
        public static int crutch;
        public static void CheckBlock(AstNode node, Context context)
        {
            for (int crutch = 0; crutch < node.ChildCount; crutch++)
            {
                //AstNodePrinter.Print(node);
                Check((AstNode)node.GetChild(crutch), context);
                AstNodePrinter.Print(node);
            }
        }

        public static OrigDataType Check(AstNode node, Context context)
        {
            switch (node.Type)
            {
                case MathExprLexer.PROGRAM:
                    {
                        if (context == null)
                            context = new Context(context);
                        CheckBlock(node, context);
                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.BLOCK:
                    {
                        context = new Context(context);
                        contexts.Add(context);
                        CheckBlock(node, context);
                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.LET:
                case MathExprLexer.VAR:
                    {
                        List<AstNode> nodes = new List<AstNode>();
                        //String str = node.GetChild(1).GetChild(0).Text;
                        OrigDataType dataType;
                        //OrigDataType dataType = strToDataType(node.GetChild(1).GetChild(0).Text);

                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            dataType = new OrigDataType(DataType.Void);
                            AstNode tempi = (AstNode)node.GetChild(i);
                            Ident ident = context.InThisContext(node.GetChild(i).Text);
                            if (ident != null)
                                throw new ApplicationException(string.Format("Identifier {0} already exists", tempi.Text));
                            String typeText = node.Type == MathExprLexer.VAR ? "VARS" : "LETS";
                            AstNode var = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.VARS, typeText));
                            var.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.IDENT, tempi.Text)));
                            nodes.Add(var);

                            for (int j = 0; j < node.GetChild(i).ChildCount; j++)
                            {
                                AstNode tempj = (AstNode)node.GetChild(i).GetChild(j);
                                if (tempj.Token.Type == MathExprLexer.TYPE && tempj.ChildCount > 0)
                                {
                                    dataType.ReturnFromType(tempj);

                                    AstNode tempType = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.TYPE, dataTypeToStr(dataType.SimpleDataType)));
                                    tempType.ODataType = dataType;

                                    var.AddChild(tempType);
                                }
                                if (tempj.Token.Type == MathExprLexer.ASSIGN)
                                {
                                    AstNode tempAssign = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.ASSIGN, "="));
                                    tempAssign.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.IDENT, tempi.Text)));
                                    tempAssign.AddChild(tempj.GetChild(0));
                                    nodes.Add(tempAssign);
                                    if (dataType.SimpleDataType == DataType.Void)
                                    {
                                        dataType = Check((AstNode)tempAssign.GetChild(1), context);

                                        AstNode tempType = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.TYPE, dataTypeToStr(dataType.SimpleDataType)));
                                        tempType.ODataType = dataType;
                                        AstNode tempCheckArrayPart = (AstNode)tempj.GetChild(0);
                                        //часть массива
                                        if (tempCheckArrayPart.Token.Type == MathExprLexer.ARRAY)
                                        {
                                            dataType.Check((AstNode)tempAssign.GetChild(1));
                                            AstNode tempTypeArr = (AstNode)tempj.GetChild(0);
                                            tempType.ODataType.ArrayCount = tempTypeArr.ODataType.ArrayCount;
                                        }
                                        //вызов функции
                                        if (tempCheckArrayPart.Token.Type == MathExprLexer.FUNC_CALL)
                                        {
                                            Check((AstNode)tempAssign.GetChild(1), context);
                                            tempType.ODataType = (tempAssign.GetChild(1) as AstNode).ODataType;
                                        }


                                        var.AddChild(tempType);
                                        crutch++;
                                    }
                                }
                            }

                            string name = nodes[i + i].GetChild(0).Text;
                            context[name] = new Ident(name, context.ParentContext == null ? IdentType.GlobalVar : IdentType.LocalVar, dataType, nodes[i + i], identIndex++);

                        }

                        Antlr.Runtime.Tree.CommonTree tree = new Antlr.Runtime.Tree.CommonTree();
                        foreach (AstNode n in nodes)
                            tree.AddChild(n);
                        node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, tree);

                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.VARS:
                case MathExprLexer.PARAMS: return new OrigDataType(DataType.Void);
                case MathExprLexer.FUNC:
                    {
                        OrigDataType dataType = new OrigDataType(strToDataType(node.GetChild(2).GetChild(0).Text));
                        string name = node.GetChild(0).Text;
                        Ident ident = context[name];
                        if (ident != null)
                            throw new ApplicationException(string.Format("Identifier {0} already exists", name));
                        Ident func = new Ident(name, IdentType.Function, dataType, node, identIndex++);
                        context[name] = func;
                        context = new Context(context);
                        contexts.Add(context);
                        AstNode _params = (AstNode)node.GetChild(1);
                        for (int i = 0; i < _params.ChildCount; i++)
                        {
                            OrigDataType paramDataType = new OrigDataType(strToDataType(_params.GetChild(i).GetChild(0).Text));
                            string paramName = _params.GetChild(i).Text;
                            if (paramDataType.SimpleDataType == DataType.Void)
                                throw new ApplicationException(string.Format("In function {0} void param {1}", name, paramName));
                            context[paramName] = new Ident(paramName, IdentType.Param, paramDataType, (AstNode)_params.GetChild(i), identIndex++);
                        }
                        context.Function = func;
                        if (dataType.SimpleDataType == DataType.Array)
                        {
                            dataType.ReturnFromType((AstNode)node.GetChild(2).GetChild(0));
                            dataType.ArrayCount++;
                            AstNode tempType = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.TYPE, dataTypeToStr(dataType.SimpleDataType)));
                            tempType.ODataType = dataType;
                            node.GetChild(2).ReplaceChildren(0, 0, tempType);
                        }
                        Check((AstNode)node.GetChild(3), context);
                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.CONVERT:
                    {
                        OrigDataType dataType = new OrigDataType(strToDataType(node.GetChild(1).Text));
                        return dataType;
                    }
                case MathExprLexer.FUNC_CALL:
                    {

                        Ident ident = context[node.GetChild(0).Text];
                        node.ODataType = ident.DataType;
                        if (ident == null)
                            throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
                        if (ident.IdentType != IdentType.Function)
                            throw new ApplicationException(string.Format("Identifier {0} is not function", node.GetChild(0).Text));
                        if (node.ChildCount == 2 && node.GetChild(1).ChildCount != ident.Node.GetChild(1).ChildCount)
                            throw new ApplicationException(string.Format("Not equals params count in function {0}", node.GetChild(0).Text));
                        for (int i = 0; i < ident.Node.GetChild(1).ChildCount; i++)
                        {
                            OrigDataType formalDataType = new OrigDataType(strToDataType(ident.Node.GetChild(1).GetChild(i).GetChild(0).Text));
                            OrigDataType factDataType = Check((AstNode)node.GetChild(1).GetChild(i), context);
                            if (formalDataType.SimpleDataType != factDataType.SimpleDataType)
                            {
                                if (formalDataType.SimpleDataType == DataType.Double && factDataType.SimpleDataType == DataType.Int)
                                    convert((AstNode)node.GetChild(1).GetChild(i), new OrigDataType(DataType.Double));
                                else
                                    throw new ApplicationException(string.Format("In function {0} param {1} incopotible types {2} {3}", node.GetChild(0).Text, i, dataTypeToStr(formalDataType.SimpleDataType), dataTypeToStr(factDataType.SimpleDataType)));
                            }
                        }
                        return new OrigDataType(strToDataType(ident.Node.GetChild(2).GetChild(0).Text));
                    }

                case MathExprLexer.IDENT:
                    {
                        Ident ident = context[node.Text];
                        if (ident == null)
                            throw new ApplicationException(string.Format("Unknown identifier {0}", node.Text));
                        if (ident.IdentType == IdentType.Function)
                        {
                            if (ident.DataType.SimpleDataType == DataType.Void)
                                throw new ApplicationException(string.Format("Function {0} returns void", ident.Name));
                            if (ident.Node.GetChild(1).ChildCount > 0)
                                throw new ApplicationException(string.Format("No params for function {0} call", ident.Name));
                            AstNode call = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.FUNC_CALL));
                            call.AddChild(node);
                            call.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.PARAMS)));
                            node.Parent.SetChild(node.ChildIndex, call);

                            node.ODataType = ident.DataType;
                            return node.ODataType;
                        }
                        else
                        {
                            node.ODataType = ident.DataType;
                            return node.ODataType;
                        }
                    }

                case MathExprLexer.NUMBER:
                    {
                        node.ODataType = node.Text.Contains(".") ? new OrigDataType(DataType.Double) : new OrigDataType(DataType.Int);
                        return node.ODataType;
                    }

                case MathExprLexer.STRINGVAL:
                    {
                        node.ODataType.SimpleDataType = DataType.String;
                        return node.ODataType;
                    }
                case MathExprLexer.TRUE:
                case MathExprLexer.FALSE:
                    {
                        node.ODataType.SimpleDataType = DataType.Bool;
                        return node.ODataType;
                    }
                case MathExprLexer.ARRAY:
                    {

                        OrigDataType dataType = new OrigDataType(DataType.Void);

                        dataType.ReturnFromValue(node);
                        node.ODataType = dataType;
                        int tmpArr = dataType.ArrayCount;
                        //int type = node.GetChild(0).Type;
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            dataType = Check((AstNode)node.GetChild(i), context);

                        }

                        return dataType;
                    }
                case MathExprLexer.ARRAYPART:
                    {
                        Ident ident = context[node.GetChild(0).Text];

                        OrigDataType dataType = new OrigDataType(ident.DataType.SimpleDataType);
                        dataType.ArrayCount = ident.DataType.ArrayCount - node.ChildCount + 1;
                        for (int i = 1; i < node.ChildCount; i++)
                        {
                            Check((AstNode)node.GetChild(i), context);
                        }
                        node.ODataType = dataType;
                        return dataType;
                    }
                case MathExprLexer.ASSIGN:
                    {

                        Ident ident = context[node.GetChild(0).Text];
                        if (node.GetChild(0).Type == MathExprLexer.ARRAYPART)
                        {
                            ident = context[node.GetChild(0).GetChild(0).Text];
                        }
                        if (ident == null)
                            throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
                        if (ident.IdentType == IdentType.Function)
                            throw new ApplicationException(string.Format("Assign to function {0}", node.GetChild(0).Text));


                        OrigDataType rightDataType = Check((AstNode)node.GetChild(1), context);
                        if (ident.DataType.SimpleDataType == DataType.Void)
                            return rightDataType;
                        //if(ident.OrigDataType == OrigDataType.Void)

                        if (ident.DataType.SimpleDataType != rightDataType.SimpleDataType)
                        {
                            if (ident.DataType.SimpleDataType == DataType.Double && rightDataType.SimpleDataType == DataType.Int)
                                convert((AstNode)node.GetChild(1), new OrigDataType(DataType.Double));
                            else
                                throw new ApplicationException(string.Format("Assign incopotible types {0} {1}", dataTypeToStr(ident.DataType.SimpleDataType), dataTypeToStr(rightDataType.SimpleDataType)));
                        }


                        return new OrigDataType(DataType.Void);
                    }

                case MathExprLexer.RETURN:
                    {
                        if (context.Function == null)
                            throw new ApplicationException(string.Format("Return not in function in line {0}", node.Line));

                        OrigDataType returnDataType = Check((AstNode)node.GetChild(0), context);
                        if (context.Function.DataType.SimpleDataType != returnDataType.SimpleDataType && context.Function.DataType.ArrayCount != returnDataType.ArrayCount)
                        {
                            if (context.Function.DataType.SimpleDataType == DataType.Double && returnDataType.SimpleDataType == DataType.Int)
                                convert((AstNode)node.GetChild(0), new OrigDataType(DataType.Double));
                            else
                                throw new ApplicationException(string.Format("Return incopotible types {0} {1}", dataTypeToStr(context.Function.DataType.SimpleDataType), dataTypeToStr(returnDataType.SimpleDataType)));
                        }
                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.SINCR:
                case MathExprLexer.EINCR:
                case MathExprLexer.SDECR:
                case MathExprLexer.EDECR:
                    {
                        OrigDataType idenDataType = Check((AstNode)node.GetChild(0), context);
                        if (idenDataType.SimpleDataType != DataType.Int && idenDataType.SimpleDataType != DataType.Double)
                            throw new ApplicationException(string.Format("In crement condition type is {0}", dataTypeToStr(idenDataType.SimpleDataType)));
                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.ADD:
                case MathExprLexer.SUB:
                case MathExprLexer.MUL:
                case MathExprLexer.DIV:
                case MathExprLexer.GE:
                case MathExprLexer.LE:
                case MathExprLexer.NE:
                case MathExprLexer.EQ:
                case MathExprLexer.GT:
                case MathExprLexer.LT:
                    {
                        bool compareOperation = true;
                        switch (node.Type)
                        {
                            case MathExprLexer.ADD:
                            case MathExprLexer.SUB:
                            case MathExprLexer.MUL:
                            case MathExprLexer.DIV:
                                compareOperation = false;
                                break;
                        }

                        OrigDataType leftDataType = Check((AstNode)node.GetChild(0), context);
                        OrigDataType rightDataType = Check((AstNode)node.GetChild(1), context);
                        if (leftDataType.SimpleDataType != DataType.Double && leftDataType.SimpleDataType != DataType.Int && leftDataType.SimpleDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("Left operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
                        if (rightDataType.SimpleDataType != DataType.Double && rightDataType.SimpleDataType != DataType.Int && leftDataType.SimpleDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("Right operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
                        if (leftDataType.SimpleDataType == DataType.Double)
                        {
                            if (rightDataType.SimpleDataType == DataType.Int)
                                convert((AstNode)node.GetChild(1), new OrigDataType(DataType.Double));
                            node.ODataType = compareOperation ? new OrigDataType(DataType.Bool) : new OrigDataType(DataType.Double);
                            return node.ODataType;
                        }
                        if (rightDataType.SimpleDataType == DataType.Double)
                        {
                            if (leftDataType.SimpleDataType == DataType.Int)
                                convert((AstNode)node.GetChild(0), new OrigDataType(DataType.Double));
                            node.ODataType = compareOperation ? new OrigDataType(DataType.Bool) : new OrigDataType(DataType.Double);
                            return node.ODataType;
                        }
                        node.ODataType = compareOperation ? new OrigDataType(DataType.Bool) : new OrigDataType(DataType.Int);
                        return node.ODataType;
                    }

                case MathExprLexer.NOT:
                    {
                        OrigDataType dataType = Check((AstNode)node.GetChild(0), context);
                        if (dataType.SimpleDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("Not operator with type {0}", dataTypeToStr(dataType.SimpleDataType)));
                        node.ODataType.SimpleDataType = DataType.Bool;
                        return node.ODataType;
                    }

                case MathExprLexer.AND:
                case MathExprLexer.OR:
                    {
                        OrigDataType leftDataType = Check((AstNode)node.GetChild(0), context);
                        OrigDataType rightDataType = Check((AstNode)node.GetChild(1), context);
                        if (leftDataType.SimpleDataType != DataType.Bool && rightDataType.SimpleDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("{0} operator with type {1}, {2}", node.Text, dataTypeToStr(leftDataType.SimpleDataType), dataTypeToStr(rightDataType.SimpleDataType)));
                        node.ODataType = new OrigDataType(DataType.Bool);
                        return node.ODataType;
                    }
                case MathExprLexer.REPEATE:
                case MathExprLexer.WHILE:
                    {
                        OrigDataType condDataType = Check((AstNode)node.GetChild(0), context);
                        if (condDataType.SimpleDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("In while condition type is {0}", dataTypeToStr(condDataType.SimpleDataType)));
                        // context = new Context(context);
                        Check((AstNode)node.GetChild(1), context);
                        return new OrigDataType(DataType.Void);
                    }

                case MathExprLexer.IF:
                    {
                        OrigDataType condDataType = Check((AstNode)node.GetChild(0), context);
                        if (condDataType.SimpleDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("In if condition type is {0}", dataTypeToStr(condDataType.SimpleDataType)));
                        //context = new Context(context);
                        Check((AstNode)node.GetChild(1), context);
                        if (node.ChildCount == 3)
                            Check((AstNode)node.GetChild(2), context);
                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.FOR:
                    {

                        for (int i = 0; i < node.ChildCount - 1; i++)
                        {
                            Check((AstNode)node.GetChild(i), context);
                        }
                        context = new Context(context);
                        CheckBlock((AstNode)node.GetChild(node.ChildCount - 1), context);

                        OrigDataType condDataType = Check((AstNode)node.GetChild(node.ChildCount - 3), context);
                        if (condDataType.SimpleDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("In while condition type is {0}", dataTypeToStr(condDataType.SimpleDataType)));

                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.SWITCH:
                    {
                        OrigDataType identDataType = Check((AstNode)node.GetChild(0), context);
                        for (int i = 1; i < node.ChildCount; i++)
                        {
                            AstNode tempi = (AstNode)node.GetChild(i);
                            for (int j = 0; j < tempi.GetChild(0).ChildCount; j++)
                            {
                                if (identDataType.SimpleDataType != Check((AstNode)tempi.GetChild(0).GetChild(j), context).SimpleDataType)
                                    throw new ApplicationException(string.Format("In switch identDataType type is {0}", dataTypeToStr(identDataType.SimpleDataType)));
                            }
                            context = new Context(context);
                            CheckBlock((AstNode)tempi.GetChild(1), context);
                            //Check((AstNode)node.GetChild(i), context);
                        }
                        //context = new Context(context);                

                        return new OrigDataType(DataType.Void);
                    }
                case MathExprLexer.PRINT:
                    {
                        if (node.ChildCount > 0)
                        {
                            Check((AstNode)node.GetChild(0), context);
                            if ((node.GetChild(0) as AstNode).ODataType.SimpleDataType != DataType.String)
                            {
                                convert((AstNode)node.GetChild(0), new OrigDataType(DataType.String));
                            }
                        }
                        return new OrigDataType(DataType.String);
                    }
                default:
                    {
                        throw new ApplicationException("Unknown token type");
                    }

            }

        }
    }
}
