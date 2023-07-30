using Tumbleweed.Boolean.From.Enumerable;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Integer = Tumbleweed.Number.Integer.System.Medium;

namespace Tumbleweed.Number.Integer.System.Medium.Is.Positive;

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
			new Integer::Bits(integer))
	)
	{
	}
}