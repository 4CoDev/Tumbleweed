using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic;
using Tumbleweed.Point.Planar.Real.Coordinate;
using Tumbleweed.Point.Planar.With;

namespace Tumbleweed.Point.Planar.Real.Arithmetic;

public sealed class QuotientOfPoints : Envelope<Any>
{
	public QuotientOfPoints(params Any<Any>[] points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}

	public QuotientOfPoints(IEnumerable<Any<Any>> points) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public QuotientOfPoints(ICollection<Any<Any>> points) : base
	(
		new Coordinates<Any>(
			new QuotientOfReals(new X(points)),
			new QuotientOfReals(new Y(points)))
	)
	{
	}
}