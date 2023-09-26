using Tumbleweed.Mathematics.Arithmetic.Real.Difference.Absolute.Of;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.Y.Arithmetic.Difference.Absolute.Of;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Multiple(
			new Value.One(first),
			new Value.One(second))
	)
	{
	}
}