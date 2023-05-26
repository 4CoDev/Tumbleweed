using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Planar.Real.Coordinate;

namespace Tumbleweed.Point.Planar.Real.Arithmetic;

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