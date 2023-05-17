using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

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