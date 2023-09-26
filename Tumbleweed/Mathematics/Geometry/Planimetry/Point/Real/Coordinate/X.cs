using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point.Real.Coordinate;

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