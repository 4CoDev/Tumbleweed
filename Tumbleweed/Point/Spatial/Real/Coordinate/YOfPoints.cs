using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Coordinate;

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