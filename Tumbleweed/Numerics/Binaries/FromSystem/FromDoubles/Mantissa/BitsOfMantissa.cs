using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class BitsOfMantissa : EnumerableEnvelope<IBit>
{
	public BitsOfMantissa(double @double) : this
	(
		new ScalarOfValue<double>(@double)
	)
	{
	}
	
	public BitsOfMantissa(IScalar<double> @double) : base
	(
		new ElementsFromLeft<IBit>(
			new BitsOfDouble(@double),
			new MantissaSize())
	)
	{
	}
}