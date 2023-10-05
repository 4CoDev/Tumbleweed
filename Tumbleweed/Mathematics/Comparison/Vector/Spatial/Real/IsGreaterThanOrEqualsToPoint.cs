using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Comparison.Boolean.All.Are;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Any = Tumbleweed.Mathematics.Number.Real.Any;
using One = Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Y.Comparison.Is.Greater.Than.Or.Equal.To.Specific.One;

namespace Tumbleweed.Mathematics.Comparison.Vector.Spatial.Real;

public sealed class IsGreaterThanOrEqualsToPoint : Envelope
{
	public IsGreaterThanOrEqualsToPoint
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new Mathematics.Vector.Spatial.Real.Coordinate.X.Comparison.Is.Greater.Than.Or.Equal.To.Specific.One(first, second),
			new One(first, second),
			new Mathematics.Vector.Spatial.Real.Coordinate.Z.Comparison.Is.Greater.Than.Or.Equal.To.Specific.One(first, second))
	)
	{
	}
}