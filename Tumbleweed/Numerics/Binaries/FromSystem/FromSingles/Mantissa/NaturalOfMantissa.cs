using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class NaturalOfMantissa : NaturalEnvelope
{
	public NaturalOfMantissa(IScalar<float> single) : base
	(
		new NaturalWithBits(
			new BitsOfMantissa(single))
	)
	{
	}
}