using Tumbleweed.Numbers.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromSingles.Mantissa;

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