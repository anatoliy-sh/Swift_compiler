using System;
using System.Runtime.Serialization;


namespace MathExpr
{
    public class MSILGeneratorException : ApplicationException
    {
        public MSILGeneratorException()
            : base()
        {
        }

        public MSILGeneratorException(string message)
            : base(message)
        {
        }

        public MSILGeneratorException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public MSILGeneratorException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
