using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Exponent;

public sealed class ExponentOfSingle : SignedEnvelope
{
	public ExponentOfSingle(float single) : this
	(
		new ScalarOfValue<float>(single)
	)
	{
	}
	
	public ExponentOfSingle(IScalar<float> single) : base
	(
		new SignedWithValues(
			new IsPositiveExponent(single),
			new NaturalOfExponent(single))
	)
	{
	}
}