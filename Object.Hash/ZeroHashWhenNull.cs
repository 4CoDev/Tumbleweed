using Tumbleweed.Property;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;
using Tumbleweed.Property.Option.From.System;

namespace Tumbleweed.Object.Hash;

public sealed class ZeroHashWhenNull : Envelope<Int32>
{
	public ZeroHashWhenNull(System.Object? option) : this
	(
		new Property.Output.With.Value.One<System.Object?>(option)
	)
	{
	}
	
	public ZeroHashWhenNull(Any<System.Object?> option) : this
	(
		new Property.Option.From.System.One<System.Object>(option)
	)
	{
	}
	
	public ZeroHashWhenNull(Property.Option.Any<System.Object> any) : base
	(
		new Actual<Int32>(
			() => Function(any))
	)
	{
	}

	private static Int32 Function(Property.Option.Any<System.Object> any)
	{
		if (any.HasValue.State) return new HashOfObject(any).Value;
		return 0;
	}
}