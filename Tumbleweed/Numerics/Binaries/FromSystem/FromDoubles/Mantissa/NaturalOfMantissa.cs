using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class NaturalOfMantissa : NaturalEnvelope
{
	public NaturalOfMantissa(double @double) : this
	(
		new ScalarOfValue<double>(@double)
	)
	{
	}
	
	public NaturalOfMantissa(IScalar<double> @double) : base
	(
		new NaturalWithBits(
			new BitsOfMantissa(@double))
	)
	{
	}
}