using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class HashOfObject : ScalarEnvelope<Int32>
{
	public HashOfObject(Object @object) : base
	(
		new ValueOfFunction<Int32>(
			@object.GetHashCode)
	)
	{
	}
}