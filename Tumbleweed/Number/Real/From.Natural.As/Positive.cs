using Tumbleweed.Number.Real.Binary.Precision.Single.From.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Integer;
using One = Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Integer.One;

namespace Tumbleweed.Number.Real.From.Natural.As;

public sealed class Positive : Real.Envelope
{
	public Positive(Number.Natural.Any number) : base
	(
		new Binary.Precision.Single.From.System.One(
			new One(
				new Integer.System.Medium.From.Natural.Tumbleweed.One(number)))
	)
	{
	}
}