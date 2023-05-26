using Tumbleweed.Number.Integer.Signed;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble.Exponent;

public sealed class ExponentOfDouble : SignedEnvelope
{
	public ExponentOfDouble(IScalar<Double> @double) : base
	(
		new SignedWithValues(
			new IsPositiveExponent(@double),
			new NaturalOfExponent(@double))
	)
	{
	}
}