using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Any = Tumbleweed.Mathematics.Number.Real.Any;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.Y.Comparison.Is.Equal.To.Specific;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Mathematics.Number.Real.Comparison.Is.Equals.To.Other.One(
			new Value.One(first),
			new Value.One(second))
	)
	{
	}
}