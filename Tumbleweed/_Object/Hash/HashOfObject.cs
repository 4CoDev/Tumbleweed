using Tumbleweed.Scalar;

namespace Tumbleweed._Object.Hash;

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