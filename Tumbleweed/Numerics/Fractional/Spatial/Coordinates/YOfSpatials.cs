using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Numerics.Spatial.Coordinates;

namespace Tumbleweed.Numerics.Fractional.Spatial.Coordinates;

public sealed class YOfSpatials : EnumerableEnvelope<IFractional>
{
	public YOfSpatials
	(
		IEnumerable<ISpatial<IFractional>> spatials
	) : base
	(
		new YOfSpatials<IFractional>(spatials)
	)
	{
	}
}