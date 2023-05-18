using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class YOfSpatials : EnumerableEnvelope<IReal>
{
	public YOfSpatials
	(
		IEnumerable<IPoint<IReal>> spatials
	) : base
	(
		new YOfPoints<IReal>(spatials)
	)
	{
	}
}