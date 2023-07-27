using Tumbleweed.Number.Integer.System.Medium;
using Tumbleweed.Number.Integer.System.Medium.Is;
using Tumbleweed.Number.Integer.System.Medium.Is.Positive;
using TW =  Tumbleweed;

namespace Tumbleweed.Number.Integer.From.System;

public class One : Integer.Envelope
{
	public One(global::System.Int32 integer) : this
	(
		new Tumbleweed.Scalar.Of.Value<Int32>(integer)
	)
	{
	}

	public One(TW.Scalar.Any<Int32> integer) : base
	(
		new Integer.With.Members(
			new State(integer), 
			new Number.Natural.From.System.One(integer))
	)
	{
	}
}