using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point.Real.Coordinate;

public sealed class Y : Tumbleweed.Enumerable.Envelope<Any>
{
	public Y(IEnumerable<Any<Any>> points) : base
	(
		new Selected<Any<Any>, Any>(
			points,
			point => point.Y)
	)
	{
	}
}