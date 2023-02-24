using Tumbleweed.Scalars;

namespace Tumbleweed.HashCodes;

public sealed class HashCodeOfObject : ScalarEnvelope<int>
{
	public HashCodeOfObject(object @object) : this
	(
		new ScalarOfValue<object>(@object)
	)
	{
	}
	
	public HashCodeOfObject(IScalar<object> @object) : base
	(
		new ScalarOfDelegate<int>(@object.GetHashCode)
	)
	{
	}
}