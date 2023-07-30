using Tumbleweed.Number.Integer.System.Medium;
using Tumbleweed.Number.Integer.System.Medium.Is;
using Tumbleweed.Number.Integer.System.Medium.Is.Positive;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using TW =  Tumbleweed;

namespace Tumbleweed.Number.Integer.From.System;

public class One : Integer.Envelope
{
	public One(global::System.Int32 integer) : this
	(
		new Value<Int32>(integer)
	)
	{
	}

	public One(Any<Int32> integer) : base
	(
		new Integer.With.Members(
			new State(integer), 
			new Number.Natural.From.System.One(integer))
	)
	{
	}
}