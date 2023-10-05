using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar.Generic;

namespace Tumbleweed.Mathematics.Vector.Planar.Real.Coordinate;

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