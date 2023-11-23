using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar.Generic;

namespace Tumbleweed.Mathematics.Vector.Planar.Real.Coordinate;

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