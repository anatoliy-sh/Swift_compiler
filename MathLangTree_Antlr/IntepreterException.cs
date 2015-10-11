using System;
using System.Runtime.Serialization;


namespace MathLang
{
  public class IntepreterException: ApplicationException
  {
    public IntepreterException()
      : base() {
    }

    public IntepreterException(string message)
      : base(message) {
    }

    public IntepreterException(string message, Exception innerException)
      : base(message, innerException) {
    }

    public IntepreterException(SerializationInfo info, StreamingContext context)
      : base(info, context) {
    }
  }
}
