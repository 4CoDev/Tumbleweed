using Tumbleweed.Number.Integer.Signed;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Mantissa;

public sealed class MantissaOfSingle : SignedEnvelope
{
	public MantissaOfSingle(IScalar<Single> single) : base
	(
		new SignedWithValues(
			new IsPositiveMantissa(single),
			new NaturalOfMantissa(single))
	)
	{
	}
}