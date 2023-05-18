using Tumbleweed.Enumerables;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Numbers.Real.Spatial.Coordinates;

public sealed class XOfSpatials : EnumerableEnvelope<IReal>
{
	public XOfSpatials
	(
		IEnumerable<IPoint<IReal>> spatials
	) : base
	(
		new XOfPoints<IReal>(spatials)
	)
	{
	}
}