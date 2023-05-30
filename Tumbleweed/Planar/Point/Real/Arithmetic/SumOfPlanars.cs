using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Planar.Point.Real.Coordinate;

namespace Tumbleweed.Planar.Point.Real.Arithmetic;

public sealed class SumOfPoints : PointEnvelope<IReal>
{
	public SumOfPoints(params IPoint<IReal>[] points) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}

	public SumOfPoints(IEnumerable<IPoint<IReal>> points) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}
	
	public SumOfPoints(ICollection<IPoint<IReal>> points) : base
	(
		new PointWithCoordinates<IReal>(
			new SumOfReals(new XOfPoints(points)),
			new SumOfReals(new YOfPoints(points)))
	)
	{
	}
}