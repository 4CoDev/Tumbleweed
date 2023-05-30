using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Planar.Point.Real.Coordinate;

namespace Tumbleweed.Planar.Point.Real.Arithmetic;

public sealed class DifferenceOfPoints : PointEnvelope<IReal>
{
	public DifferenceOfPoints(params IPoint<IReal>[] points) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}

	public DifferenceOfPoints(IEnumerable<IPoint<IReal>> points) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}
	
	public DifferenceOfPoints(ICollection<IPoint<IReal>> points) : base
	(
		new PointWithCoordinates<IReal>(
			new DifferenceOfReals(new XOfPoints(points)),
			new DifferenceOfReals(new YOfPoints(points)))
	)
	{
	}
}