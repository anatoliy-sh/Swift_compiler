using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathExpr
{
    public class OrigDataType
    {

        DataType simple;
        int arrayCount;
        int alength;

        public int ALength { get { return alength; } set { alength = value; } }

        public DataType SimpleDataType { get { return simple; } set { simple = value; } }

        public int ArrayCount { get { return arrayCount; } set { arrayCount = value; } }

        public OrigDataType(DataType dataType)
        {
            SimpleDataType = dataType;
            ArrayCount = 0;
        }

        public void ReturnFromValue(AstNode node)
        {
            AstNode tempNode = node;
            int count = 0;
            SimpleDataType = SemanticChecker.strToDataType(tempNode.Text);
            while (tempNode.ChildCount > 0)
            {
                count++;
                tempNode = (AstNode)tempNode.GetChild(0);
            }
            ArrayCount = count;
        }

        public void ReturnFromType(AstNode node)
        {
            AstNode tempNode = node;
            int count = 0;
            while (tempNode.ChildCount > 0)
            {
                count++;
                tempNode = (AstNode)tempNode.GetChild(0);
            }
            ArrayCount = count - 1;
            alength = Convert.ToInt32(node.GetChild(1).Text);
            SimpleDataType = SemanticChecker.strToDataType(tempNode.Text);
            
            //return null;
        }

        public void Check(AstNode node)
        {
            if (node.ChildCount > 0)
            {
                for (int i = 0; i < node.ChildCount; i++)
                {
                    AstNode child = (AstNode)node.GetChild(i);
                    if (child.ODataType.SimpleDataType != DataType.Array && child.ODataType.SimpleDataType != this.SimpleDataType)
                        throw new ApplicationException(string.Format("Invalid array"));
                    Check((AstNode)node.GetChild(i));
                }
            }
        }



        //public OrigDataType CheckDataType(AstNode node)

    }
}
