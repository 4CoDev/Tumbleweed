using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

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