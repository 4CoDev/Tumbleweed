using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Planar.Point.Real.Coordinate;

namespace Tumbleweed.Planar.Point.Real.Arithmetic;

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