using Tumbleweed.Boolean.Comparison.Either.Is;
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.X.Comparison.Is.Greater.Than.Or.Equal.To.Specific;

public sealed class One : Boolean.Envelope
{
	public One
	(
		Any<Number.Real.Any> first,
		Any<Number.Real.Any> second
	) : base
	(
		new True(
			new Just.Specific.One(first, second),
			new Is.Equal.To.Specific.One(first, second))
	)
	{
	}
}