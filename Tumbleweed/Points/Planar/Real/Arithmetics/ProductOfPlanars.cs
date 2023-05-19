using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Points.Planar.Real.Coordinates;

namespace Tumbleweed.Points.Planar.Real.Arithmetics;

public sealed class ProductOfPoints : PointEnvelope<IReal>
{
	public ProductOfPoints(params IPoint<IReal>[] points) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}

	public ProductOfPoints(IEnumerable<IPoint<IReal>> points) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}
	
	public ProductOfPoints(ICollection<IPoint<IReal>> points) : base
	(
		new PointWithCoordinates<IReal>(
			new ProductOfReals(new XOfPoints(points)),
			new ProductOfReals(new YOfPoints(points)))
	)
	{
	}
}