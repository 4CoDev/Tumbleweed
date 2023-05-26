using Tumbleweed.Number.Integer.Signed;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Exponent;

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