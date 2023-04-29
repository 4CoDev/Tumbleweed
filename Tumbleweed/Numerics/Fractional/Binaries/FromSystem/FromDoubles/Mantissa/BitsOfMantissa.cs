using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class BitsOfMantissa : EnumerableEnvelope<IBoolean>
{
	public BitsOfMantissa(Double @double) : this
	(
		new ScalarValue<Double>(@double)
	)
	{
	}
	
	public BitsOfMantissa(IScalar<Double> @double) : base
	(
		new ElementsFromLeft<IBoolean>(
			new BitsOfDouble(@double),
			new MantissaSize())
	)
	{
	}
}