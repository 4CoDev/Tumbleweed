using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Object.Hash;

public sealed class HashOfNullable : ScalarEnvelope<Int32>
{
	public HashOfNullable(Object? nullable) : this
	(
		new NullableFromSystem<Object>(nullable)
	)
	{
	}
	
	public HashOfNullable(INullable<Object> nullable) : base
	(
		new ResultOfFunction<Int32>(
			nullable.GetHashCode)
	)
	{
	}
}