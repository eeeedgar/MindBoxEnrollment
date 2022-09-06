using System.Runtime.Serialization;

namespace EeeeGeometry.Tools;

public class EeeeGeometryException : Exception
{
    
    public EeeeGeometryException()
    {
    }

    public EeeeGeometryException(string message)
        : base(message)
    {
    }

    public EeeeGeometryException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected EeeeGeometryException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
    
}