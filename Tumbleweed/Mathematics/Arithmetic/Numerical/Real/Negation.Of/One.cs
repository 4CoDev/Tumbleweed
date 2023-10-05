using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Arithmetics;

namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Negation.Of;

public sealed class One : Envelope
{
	public One(Any real) : base
	(
		new Number.Real.Binary.Precision.Single.From.System.One(
			new Negative(
				new Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(real)))
	)
	{
	}
}