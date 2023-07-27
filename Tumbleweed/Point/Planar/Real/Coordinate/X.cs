using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Planar.Real.Coordinate;

public sealed class X : Tumbleweed.Enumerable.Envelope<Any>
{
	public X(IEnumerable<Any<Any>> points) : base
	(
		new Selected<Any<Any>, Any>(
			points,
			point => point.X)
	)
	{
	}
}