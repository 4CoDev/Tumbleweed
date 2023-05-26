using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Coordinate;

namespace Tumbleweed.Point.Spatial.Real.Coordinate;

public sealed class ZOfPoints : EnumerableEnvelope<IReal>
{
	public ZOfPoints(params IPoint<IReal>[] points) : this
	(
		new EnumerableWithElements<IPoint<IReal>>(points)
	)
	{
	}
	
	public ZOfPoints
	(
		IEnumerable<IPoint<IReal>> spatials
	) : base
	(
		new ZOfPoints<IReal>(spatials)
	)
	{
	}
}