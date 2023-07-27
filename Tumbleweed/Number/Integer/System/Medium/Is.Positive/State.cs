using Tumbleweed.Boolean.From.Enumerable;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Integer = Tumbleweed.Number.Integer.System.Medium;

namespace Tumbleweed.Number.Integer.System.Medium.Is.Positive;

public sealed class State : Boolean.Envelope
{
	public State(System::Int32 integer) : this
	(
		new Scalar::Of.Value<System::Int32>(integer)
	)
	{
	}
	
	public State(Scalar::Any<System::Int32> integer) : base
	(
		new Last(
			new Integer::Bits(integer))
	)
	{
	}
}