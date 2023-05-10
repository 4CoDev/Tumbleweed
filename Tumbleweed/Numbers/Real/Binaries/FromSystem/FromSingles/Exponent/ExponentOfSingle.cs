using Tumbleweed.Numbers.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromSingles.Exponent;

public sealed class ExponentOfSingle : SignedEnvelope
{
	public ExponentOfSingle(Single single) : this
	(
		new ScalarValue<Single>(single)
	)
	{
	}
	
	public ExponentOfSingle(IScalar<Single> single) : base
	(
		new SignedWithValues(
			new IsPositiveExponent(single),
			new NaturalOfExponent(single))
	)
	{
	}
}