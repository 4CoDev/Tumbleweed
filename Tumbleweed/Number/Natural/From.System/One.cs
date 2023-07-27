using Tumbleweed.Number.Integer.System.Medium;
using TW = Tumbleweed;

namespace Tumbleweed.Number.Natural.From.System;

public sealed class One : Natural.Envelope
{
	public One(Int32 integer) : this
	(
		new Tumbleweed.Scalar.Of.Value<Int32>(integer)
	)
	{
	}
	
	public One(TW.Scalar.Any<Int32> integer) : base
	(
		new Natural.With.Bits.New(
			new Integer.System.Medium.As.Natural(integer))
	)
	{
	}
}