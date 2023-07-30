using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Tumbleweed.Scalar.Nullable.From.System;

namespace Tumbleweed.Object.Hash;

public sealed class ZeroHashWhenNull : Envelope<Int32>
{
	public ZeroHashWhenNull(System.Object? nullable) : this
	(
		new Value<System.Object?>(nullable)
	)
	{
	}
	
	public ZeroHashWhenNull(Any<System.Object?> nullable) : this
	(
		new One<System.Object>(nullable)
	)
	{
	}
	
	public ZeroHashWhenNull(Scalar.Nullable.Any<System.Object> any) : base
	(
		new Actual<Int32>(
			() => Function(any))
	)
	{
	}

	private static Int32 Function(Scalar.Nullable.Any<System.Object> any)
	{
		if (any.HasValue.State) return new HashOfObject(any).Value;
		return 0;
	}
}