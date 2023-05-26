using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Mantissa;

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