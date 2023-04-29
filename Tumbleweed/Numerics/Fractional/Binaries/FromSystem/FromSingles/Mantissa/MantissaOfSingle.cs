using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromSingles.Mantissa;

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