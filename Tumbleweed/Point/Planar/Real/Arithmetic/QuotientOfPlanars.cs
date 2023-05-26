using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Planar.Real.Coordinate;

namespace Tumbleweed.Point.Planar.Real.Arithmetic;

public sealed class QuotientOfPoints : PointEnvelope<IReal>
{
	public QuotientOfPoints(params IPoint<IReal>[] points) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}

	public QuotientOfPoints(IEnumerable<IPoint<IReal>> points) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}
	
	public QuotientOfPoints(ICollection<IPoint<IReal>> points) : base
	(
		new PointWithCoordinates<IReal>(
			new QuotientOfReals(new XOfPoints(points)),
			new QuotientOfReals(new YOfPoints(points)))
	)
	{
	}
}