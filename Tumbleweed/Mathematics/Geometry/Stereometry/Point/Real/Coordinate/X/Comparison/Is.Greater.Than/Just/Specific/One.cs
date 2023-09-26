using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Any = Tumbleweed.Mathematics.Number.Real.Any;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.X.Comparison.Is.Greater.Than.Just.Specific;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Mathematics.Comparison.Number.Real.Is.Greater.Than.One(
			new Value.One(first),
			new Value.One(second))
	)
	{
	}
}