using System.Collections.Generic;
using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathExpr
{
  public class AstNode: CommonTree
  {
    public AstNode()
      : base() {
    }

    public AstNode(IToken t)
      : base(t) {
    }

    public AstNode(CommonTree node)
      : base(node) {

    }

    private OrigDataType datatype = new OrigDataType(DataType.Void);

    public OrigDataType ODataType { get { return datatype; } set { datatype = value; } }

    public override string ToString()
    {
        string result = base.ToString();
        if (ODataType.SimpleDataType != DataType.Void)
            result += ", " + SemanticChecker.dataTypeToStr(ODataType.SimpleDataType);
        if (ODataType.ArrayCount != 0)
            result += ", " + Convert.ToString(ODataType.ArrayCount);
        return result;
    }
  }


  public class AstNodeTreeAdapter: CommonTreeAdaptor
  {
      public override object Create(IToken payload)
      {
          return new AstNode(payload);
      }
  }
}
