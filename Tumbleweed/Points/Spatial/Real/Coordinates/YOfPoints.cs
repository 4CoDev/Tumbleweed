using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Coordinates;

public sealed class YOfPoints : EnumerableEnvelope<IReal>
{
	public YOfPoints(params IPoint<IReal>[] points) : this
	(
		new EnumerableWithElements<IPoint<IReal>>(points)
	)
	{
	}
	
	public YOfPoints
	(
		IEnumerable<IPoint<IReal>> points
	) : base
	(
		new YOfPoints<IReal>(points)
	)
	{
	}
}