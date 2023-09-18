using Tumbleweed.Boolean.Comparison.Either.Is;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison.Is.Equal.To.Specific;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison.Is.Less.Than.Just.Specific;
using Any = Tumbleweed.Number.Real.Any;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison.Is.Less.Than.Just.Specific.One;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Z.Comparison.Is.Less.Than.Or.Equal.To.Specific;

public sealed class One : Boolean.Envelope
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