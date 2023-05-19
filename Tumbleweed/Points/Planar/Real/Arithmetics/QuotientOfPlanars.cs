using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar.Real.Coordinates;

namespace Tumbleweed.Points.Planar.Real.Arithmetics;

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