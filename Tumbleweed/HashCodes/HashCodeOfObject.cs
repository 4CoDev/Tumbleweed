using Tumbleweed.Scalars;

namespace Tumbleweed.HashCodes;

public sealed class HashCodeOfObject : ScalarEnvelope<int>
{
	public HashCodeOfObject(object @object) : base
	(
		new ValueOfDelegate<int>(@object.GetHashCode)
	)
	{
	}
}