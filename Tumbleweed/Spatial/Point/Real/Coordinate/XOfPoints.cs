using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Coordinate;

public sealed class XOfPoints : EnumerableEnvelope<IReal>
{
	public XOfPoints(params IPoint<IReal>[] points) : this
	(
		new EnumerableWithElements<IPoint<IReal>>(points)
	)
	{
	}
	
	public XOfPoints
	(
		IEnumerable<IPoint<IReal>> points
	) : base
	(
		new XOfPoints<IReal>(points)
	)
	{
	}
}