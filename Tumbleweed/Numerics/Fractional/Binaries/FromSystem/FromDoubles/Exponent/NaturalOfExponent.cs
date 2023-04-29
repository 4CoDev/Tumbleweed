using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromDoubles.Exponent;

public sealed class NaturalOfExponent : NaturalEnvelope
{
	public NaturalOfExponent(IScalar<Double> @double) : base
	(
		new NaturalWithBits(
			new BitsOfExponent(@double))
	)
	{
	}
}