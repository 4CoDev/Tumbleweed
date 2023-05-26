using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Object.Hash;

public sealed class ZeroHashWhenNull : ScalarEnvelope<Int32>
{
	public ZeroHashWhenNull(Object? nullable) : this
	(
		new ScalarValue<Object?>(nullable)
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
		new ResultOfFunction<Int32>(
			() => Function(nullable))
	)
	{
	}

	private static Int32 Function(INullable<Object> nullable)
	{
		if (nullable.Existing.State) return new HashOfObject(nullable).Value;
		return 0;
	}
}