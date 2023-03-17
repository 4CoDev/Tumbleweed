using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class NaturalOfMantissa : NaturalEnvelope
{
	public NaturalOfMantissa(Double @double) : this
	(
		new ScalarOfValue<Double>(@double)
	)
	{
	}
	
	public NaturalOfMantissa(IScalar<Double> @double) : base
	(
		new NaturalWithBits(
			new BitsOfMantissa(@double))
	)
	{
	}
}