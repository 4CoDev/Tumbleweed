using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Numerics.Spatial.Coordinates;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates;

public sealed class ZOfSpatials : EnumerableEnvelope<IFractional>
{
	public ZOfSpatials
	(
		IEnumerable<ISpatial<IFractional>> spatials
	) : base
	(
		new ZOfSpatials<IFractional>(spatials)
	)
	{
	}
}