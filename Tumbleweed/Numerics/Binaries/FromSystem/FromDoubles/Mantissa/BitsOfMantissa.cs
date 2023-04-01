using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class BitsOfMantissa : EnumerableEnvelope<IBit>
{
	public BitsOfMantissa(Double @double) : this
	(
		new ScalarValue<Double>(@double)
	)
	{
	}
	
	public BitsOfMantissa(IScalar<Double> @double) : base
	(
		new ElementsFromLeft<IBit>(
			new BitsOfDouble(@double),
			new MantissaSize())
	)
	{
	}
}