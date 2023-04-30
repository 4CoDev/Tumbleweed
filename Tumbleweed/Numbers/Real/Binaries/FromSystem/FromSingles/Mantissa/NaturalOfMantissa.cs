using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class NaturalOfMantissa : NaturalEnvelope
{
	public NaturalOfMantissa(IScalar<Single> single) : base
	(
		new NaturalWithBits(
			new BitsOfMantissa(single))
	)
	{
	}
}