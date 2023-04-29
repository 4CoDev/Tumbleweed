using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromDoubles.Exponent;

public sealed class BitsOfExponent : EnumerableEnvelope<IBoolean>
{
	public BitsOfExponent(IScalar<Double> @double) : base
	(
		new ElementsFromMiddle<IBoolean>(
			new BitsOfDouble(@double), 52, 61)
	)
	{
	}
}