using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Exponent;

public sealed class NaturalOfExponent : NaturalEnvelope
{
	public NaturalOfExponent(Single single) : this
	(
		new ScalarOfValue<Single>(single)
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