using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles;

public sealed class BitsOfDouble : EnumerableEnvelope<IBit>
{
	public BitsOfDouble(IScalar<double> @double) : base
	(
		new BitsOfBytes(
			new BytesOfDouble(@double))
	)
	{
	}
}