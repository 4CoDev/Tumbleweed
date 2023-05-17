using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class YOfSpatials : EnumerableEnvelope<IReal>
{
	public YOfSpatials
	(
		IEnumerable<ISpatial<IReal>> spatials
	) : base
	(
		new YOfSpatials<IReal>(spatials)
	)
	{
	}
}