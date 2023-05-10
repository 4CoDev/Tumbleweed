using Tumbleweed.Nullables;
using Tumbleweed.Nullables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Objects.Hashes;

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