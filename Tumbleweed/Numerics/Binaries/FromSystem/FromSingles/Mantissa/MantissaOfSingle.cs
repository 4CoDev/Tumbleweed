using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class MantissaOfSingle : SignedEnvelope
{
	public MantissaOfSingle(IScalar<float> single) : base
	(
		new SignedWithValues(
			new IsPositiveMantissa(single),
			new NaturalOfMantissa(single))
	)
	{
	}
}