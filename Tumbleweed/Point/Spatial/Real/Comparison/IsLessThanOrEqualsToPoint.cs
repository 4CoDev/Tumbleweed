using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Comparison.Boolean.All.Are;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Coordinate.X.Comparison;
using Tumbleweed.Point.Spatial.Real.Coordinate.X.Comparison.Is.Less.Than.Or.Equal.To.Specific;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y.Comparison;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y.Comparison.Is.Less.Than.Or.Equal.To.Specific;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison.Is.Less.Than.Or.Equal.To.Specific;
using Any = Tumbleweed.Mathematics.Number.Real.Any;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Y.Comparison.Is.Less.Than.Or.Equal.To.Specific.One;

namespace Tumbleweed.Point.Spatial.Real.Comparison;

public sealed class IsLessThanOrEqualsToPoint : Envelope
{
	public IsLessThanOrEqualsToPoint
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new Coordinate.X.Comparison.Is.Less.Than.Or.Equal.To.Specific.One(first, second),
			new One(first, second),
			new Coordinate.Z.Comparison.Is.Less.Than.Or.Equal.To.Specific.One(first, second))
	)
	{
	}
}