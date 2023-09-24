using One = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Integer.One;

namespace Tumbleweed.Mathematics.Number.Real.From.Natural.As;

public sealed class Positive : Tumbleweed.Mathematics.Number.Real.Envelope
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