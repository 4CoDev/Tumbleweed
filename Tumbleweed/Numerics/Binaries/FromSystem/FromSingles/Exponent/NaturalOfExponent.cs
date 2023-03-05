using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Exponent;

public sealed class NaturalOfExponent : NaturalEnvelope
{
	public NaturalOfExponent(float single) : this
	(
		new ScalarOfValue<float>(single)
	)
	{
	}
	
	public NaturalOfExponent(IScalar<float> single) : base
	(
		new NaturalWithBits(
			new BitsOfExponent(single))
	)
	{
	}
}