using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Exponent;

public sealed class BitsOfExponent : EnumerableEnvelope<IBit>
{
	public BitsOfExponent(IScalar<Double> @double) : base
	(
		new ElementsFromMiddle<IBit>(
			new BitsOfDouble(@double), 52, 61)
	)
	{
	}
}