using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Exponent;

public sealed class NaturalOfExponent : NaturalEnvelope
{
	public NaturalOfExponent(Single single) : this
	(
		new ScalarValue<Single>(single)
	)
	{
	}
	
	public NaturalOfExponent(IScalar<Single> single) : base
	(
		new NaturalWithBits(
			new BitsOfExponent(single))
	)
	{
	}
}