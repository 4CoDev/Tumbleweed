using Tumbleweed.Mathematics.Number.Real;
using One = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System.One;

namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Rounding.Nearest.As;

public sealed class Real : Envelope
{
	public Real(Any real) : base
	(
		new One(
			new Number.Real.Binary.Precision.Single.System.Arithmetics.Rounding.Nearest.As.Real(
				new Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}