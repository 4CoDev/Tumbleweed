using One = Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One;

namespace Tumbleweed.Number.Real.Arithmetic.Rounding.Nearest.As;

public sealed class Real : Envelope
{
	public Real(Any real) : base
	(
		new One(
			new Binary.Precision.Single.System.Arithmetics.Rounding.Nearest.As.Real(
				new Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}