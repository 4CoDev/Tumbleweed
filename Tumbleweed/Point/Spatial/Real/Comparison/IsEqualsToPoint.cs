using Tumbleweed.Boolean.Comparison.All.Are;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Coordinate.X.Comparison;
using Tumbleweed.Point.Spatial.Real.Coordinate.X.Comparison.Is.Equal.To.Specific;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y.Comparison;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y.Comparison.Is.Equal.To.Specific;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison.Is.Equal.To.Specific;
using Any = Tumbleweed.Number.Real.Any;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Y.Comparison.Is.Equal.To.Specific.One;

namespace Tumbleweed.Point.Spatial.Real.Comparison;

public sealed class IsEqualsToPoint : Boolean.Envelope
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