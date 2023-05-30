using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison;
using Tumbleweed.Spatial.Point.Real.Coordinate;

namespace Tumbleweed.Spatial.Point.Real.Comparison;

public sealed class LargestOfPoints : PointEnvelope<IReal>
{
	public LargestOfPoints
	(
		params IPoint<IReal>[] spatials
	) : this
	(
		new EnumerableWithElements<IPoint<IReal>>(spatials)
	)
	{
	}
	
	public LargestOfPoints
	(
		IEnumerable<IPoint<IReal>> points
	) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}
	
	public LargestOfPoints
	(
		ICollection<IPoint<IReal>> points
	) : base
	(
		new PointWithCoordinates<IReal>(
			new LargestOfReals(new XOfPoints(points)),
			new LargestOfReals(new YOfPoints(points)),
			new LargestOfReals(new ZOfPoints(points)))
	)
	{
	}
}