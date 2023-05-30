using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Coordinate;

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