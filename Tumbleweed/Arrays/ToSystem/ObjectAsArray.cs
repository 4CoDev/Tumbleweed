using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.ToSystem;

public sealed class ObjectAsArray : ScalarEnvelope<Array>
{
	public ObjectAsArray(Object @object) : this
	(
		new ScalarValue(@object)
	)
	{
	}
	
	public ObjectAsArray(IScalar<Object> @object) : base
	(
		new ObjectAsType<Array>(@object)
	)
	{
	}
}