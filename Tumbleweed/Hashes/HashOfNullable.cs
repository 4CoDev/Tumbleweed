using Tumbleweed.Nullability;
using Tumbleweed.Nullability.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

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
		new ValueOfFunction<Int32>(
			nullable.GetHashCode)
	)
	{
	}
}