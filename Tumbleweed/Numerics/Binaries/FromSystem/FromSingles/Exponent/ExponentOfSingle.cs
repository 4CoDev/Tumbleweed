using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Exponent;

public sealed class ExponentOfSingle : SignedEnvelope
{
	public ExponentOfSingle(Single single) : this
	(
		new ScalarOfValue<Single>(single)
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