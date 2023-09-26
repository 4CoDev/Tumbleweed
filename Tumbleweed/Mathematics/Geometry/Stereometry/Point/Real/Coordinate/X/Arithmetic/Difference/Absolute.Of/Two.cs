using Tumbleweed.Mathematics.Arithmetic.Real.Difference.Absolute.Of;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.X.Value;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.X.Arithmetic.Difference.Absolute.Of;

public sealed class Two : Envelope
{
	public Two
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Multiple(
			new One(first),
			new One(second))
	)
	{
	}
}