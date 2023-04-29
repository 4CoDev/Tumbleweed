using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromSingles.Exponent;

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