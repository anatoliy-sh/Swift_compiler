using System;
using System.Runtime.Serialization;


namespace MathLang
{
  public class ParserBaseException: ApplicationException
  {
    public ParserBaseException()
      : base() {
    }

    public ParserBaseException(string message)
      : base(message) {
    }

    public ParserBaseException(string message, Exception innerException)
      : base(message, innerException) {
    }

    public ParserBaseException(SerializationInfo info, StreamingContext context)
      : base(info, context) {
    }
  }
}
