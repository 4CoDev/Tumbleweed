using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class ZOfSpatials : EnumerableEnvelope<IReal>
{
	public ZOfSpatials
	(
		IEnumerable<ISpatial<IReal>> spatials
	) : base
	(
		new ZOfSpatials<IReal>(spatials)
	)
	{
	}
}