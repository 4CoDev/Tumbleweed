using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Planar.Real.Coordinate;
using Tumbleweed.Point.Planar.With;

namespace Tumbleweed.Point.Planar.Real.Arithmetic;

public sealed class SumOfPoints : Envelope<Any>
{
	public SumOfPoints(params Any<Any>[] points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}

	public SumOfPoints(IEnumerable<Any<Any>> points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public SumOfPoints(ICollection<Any<Any>> points) : base
	(
		new Coordinates<Any>(
			new SumOfReals(new X(points)),
			new SumOfReals(new Y(points)))
	)
	{
	}
}