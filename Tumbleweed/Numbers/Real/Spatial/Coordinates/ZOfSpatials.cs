using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class ZOfSpatials : EnumerableEnvelope<IReal>
{
	public ZOfSpatials
	(
		IEnumerable<IPoint<IReal>> spatials
	) : base
	(
		new ZOfPoints<IReal>(spatials)
	)
	{
	}
}