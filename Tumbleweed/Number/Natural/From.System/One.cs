using Tumbleweed.Number.Integer.System.Medium;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using TW = Tumbleweed;

namespace Tumbleweed.Number.Natural.From.System;

public sealed class One : Natural.Envelope
{
	public One(Int32 integer) : this
	(
		new Value<Int32>(integer)
	)
	{
	}
	
	public One(Any<Int32> integer) : base
	(
		new Natural.With.Bits.New(
			new Integer.System.Medium.As.Natural(integer))
	)
	{
	}
}