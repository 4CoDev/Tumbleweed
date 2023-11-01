using Tumbleweed.Mathematics.Boolean.From.Enumerable;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.Is.Positive;

public sealed class State : Boolean.Envelope
{
	public State(System::Int32 integer) : this
	(
		new Value<System::Int32>(integer)
	)
	{
	}
	
	public State(Any<System::Int32> integer) : base
	(
		new Last(
			new Bits(integer))
	)
	{
	}
}