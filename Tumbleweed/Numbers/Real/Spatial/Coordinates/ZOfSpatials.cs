using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

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