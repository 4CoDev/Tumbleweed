using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromDoubles.Exponent;

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