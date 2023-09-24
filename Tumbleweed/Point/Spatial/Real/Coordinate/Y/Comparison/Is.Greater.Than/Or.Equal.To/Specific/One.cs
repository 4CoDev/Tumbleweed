using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Comparison.Boolean.Either.Is;
using Tumbleweed.Point.Spatial.Generic;
using Any = Tumbleweed.Mathematics.Number.Real.Any;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Y.Comparison.Is.Greater.Than.Just.Specific.One;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Y.Comparison.Is.Greater.Than.Or.Equal.To.Specific;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new True(
			new Just.Specific.One(first, second),
			new Is.Equal.To.Specific.One(first, second))
	)
	{
	}
}