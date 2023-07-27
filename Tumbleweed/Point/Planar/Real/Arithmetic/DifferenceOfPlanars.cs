using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Planar.Real.Coordinate;
using Tumbleweed.Point.Planar.With;

namespace Tumbleweed.Point.Planar.Real.Arithmetic;

public sealed class DifferenceOfPoints : Envelope<Any>
{
	public DifferenceOfPoints(params Any<Any>[] points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}

	public DifferenceOfPoints(IEnumerable<Any<Any>> points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public DifferenceOfPoints(ICollection<Any<Any>> points) : base
	(
		new Coordinates<Any>(
			new DifferenceOfReals(new X(points)),
			new DifferenceOfReals(new Y(points)))
	)
	{
	}
}