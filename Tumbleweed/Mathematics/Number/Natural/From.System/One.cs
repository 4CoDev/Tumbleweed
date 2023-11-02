using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace Tumbleweed.Mathematics.Number.Natural.From.System;

public sealed class One : Tumbleweed.Mathematics.Number.Natural.Envelope
{
	public One(Int32 integer) : this
	(
		new One<Int32>(integer)
	)
	{
	}
	
	public One(Any<Int32> integer) : base
	(
		new Tumbleweed.Mathematics.Number.Natural.With.Bits.New(
			new Tumbleweed.Mathematics.Number.Integer.System.Medium.As.Natural(integer))
	)
	{
	}
}