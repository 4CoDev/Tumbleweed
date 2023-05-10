using Tumbleweed.Scalars;

namespace Tumbleweed.Objects.Hashes;

public sealed class HashOfObject : ScalarEnvelope<Int32>
{
	public HashOfObject(Object @object) : base
	(
		new ResultOfFunction<Int32>(
			@object.GetHashCode)
	)
	{
	}
}