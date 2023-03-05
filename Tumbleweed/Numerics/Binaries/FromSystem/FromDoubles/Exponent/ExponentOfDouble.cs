using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Exponent;

public sealed class ExponentOfDouble : SignedEnvelope
{
	public ExponentOfDouble(IScalar<double> @double) : base
	(
		new SignedWithValues(
			new IsPositiveExponent(@double),
			new NaturalOfExponent(@double))
	)
	{
	}
}