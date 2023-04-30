using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class XOfSpatials : EnumerableEnvelope<IReal>
{
	public XOfSpatials
	(
		IEnumerable<ISpatial<IReal>> spatials
	) : base
	(
		new XOfSpatials<IReal>(spatials)
	)
	{
	}
}