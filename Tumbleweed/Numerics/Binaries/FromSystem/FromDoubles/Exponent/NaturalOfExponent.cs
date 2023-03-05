using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Exponent;

public sealed class NaturalOfExponent : NaturalEnvelope
{
	public NaturalOfExponent(IScalar<double> @double) : base
	(
		new NaturalWithBits(
			new BitsOfExponent(@double))
	)
	{
	}
}