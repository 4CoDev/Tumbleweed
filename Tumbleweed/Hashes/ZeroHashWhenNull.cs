using Tumbleweed.Nullability;
using Tumbleweed.Nullability.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class ZeroHashWhenNull : ScalarEnvelope<Int32>
{
	public ZeroHashWhenNull(Object? nullable) : this
	(
		new ScalarOfValue<Object?>(nullable)
	)
	{
	}
	
	public ZeroHashWhenNull(IScalar<Object?> nullable) : this
	(
		new NullableFromSystem<Object>(nullable)
	)
	{
	}
	
	public ZeroHashWhenNull(INullable<Object> nullable) : base
	(
		new ValueOfFunction<Int32>(
			() => Function(nullable))
	)
	{
	}

	private static Int32 Function(INullable<Object> nullable)
	{
		if (nullable.Exists.State) return new HashOfObject(nullable).Value;
		return 0;
	}
}