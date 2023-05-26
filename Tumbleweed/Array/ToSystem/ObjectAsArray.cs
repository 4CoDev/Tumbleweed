using Tumbleweed.Scalar;

namespace Tumbleweed.Array.ToSystem;

public sealed class ObjectAsArray : ScalarEnvelope<System.Array>
{
	public ObjectAsArray(Object @object) : this
	(
		new ScalarValue(@object)
	)
	{
	}
	
	public ObjectAsArray(IScalar<Object> @object) : base
	(
		new ObjectAsType<System.Array>(@object)
	)
	{
	}
}