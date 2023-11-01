using Tumbleweed.Property;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;
using Tumbleweed.Property.Nullable.From.System;

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
	
	public ZeroHashWhenNull(Property.Nullable.Any<System.Object> any) : base
	(
		new Actual<Int32>(
			() => Function(any))
	)
	{
	}

	private static Int32 Function(Property.Nullable.Any<System.Object> any)
	{
		if (any.HasValue.State) return new HashOfObject(any).Value;
		return 0;
	}
}