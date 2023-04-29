using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromDoubles;

public sealed class BitsOfDouble : EnumerableEnvelope<IBoolean>
{
	public BitsOfDouble(IScalar<Double> @double) : base
	(
		new BitsOfBytes(
			new BytesOfDouble(@double))
	)
	{
	}
}