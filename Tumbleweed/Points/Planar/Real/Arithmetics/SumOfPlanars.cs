using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar.Real.Coordinates;

namespace Tumbleweed.Points.Planar.Real.Arithmetics;

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