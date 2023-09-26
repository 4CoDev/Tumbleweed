using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Comparison.Boolean.All.Are;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Any = Tumbleweed.Mathematics.Number.Real.Any;
using One = Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.Y.Comparison.Is.Equal.To.Specific.One;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Comparison;

public sealed class IsEqualsToPoint : Envelope
{
	public IsEqualsToPoint
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new Coordinate.X.Comparison.Is.Equal.To.Specific.One(first, second),
			new One(first, second),
			new Coordinate.Z.Comparison.Is.Equal.To.Specific.One(first, second))
	)
	{
	}
}