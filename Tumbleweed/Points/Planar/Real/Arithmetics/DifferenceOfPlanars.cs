using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar.Real.Coordinates;

namespace Tumbleweed.Points.Planar.Real.Arithmetics;

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