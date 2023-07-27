using Tumbleweed.Nullable.From.System;
using Tumbleweed.Scalar;

namespace Tumbleweed.Object.Hash;

public sealed class ZeroHashWhenNull : Envelope<Int32>
{
	public ZeroHashWhenNull(System.Object? nullable) : this
	(
		new Tumbleweed.Scalar.Of.Value<System.Object?>(nullable)
	)
	{
	}
	
	public ZeroHashWhenNull(Scalar.Any<System.Object?> nullable) : this
	(
		new One<System.Object>(nullable)
	)
	{
	}
	
	public ZeroHashWhenNull(Nullable.Any<System.Object> any) : base
	(
		new Scalar.Function.Result<Int32>(
			() => Function(any))
	)
	{
	}

	private static Int32 Function(Nullable.Any<System.Object> any)
	{
		if (any.HasValue.State) return new HashOfObject(any).Value;
		return 0;
	}
}