using Tumbleweed.Mathematics.Number.Integer.System.Medium.Is.Positive;
using Tumbleweed.Mathematics.Number.Integer.With.Member;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

namespace Tumbleweed.Mathematics.Number.Integer.From.System;

public class One : Tumbleweed.Mathematics.Number.Integer.Envelope
{
	public One(global::System.Int32 integer) : this
	(
		new Value<Int32>(integer)
	)
	{
	}

	public One(Any<Int32> integer) : base
	(
		new Definition(
			new State(integer), 
			new Number.Natural.From.System.One(integer))
	)
	{
	}
}