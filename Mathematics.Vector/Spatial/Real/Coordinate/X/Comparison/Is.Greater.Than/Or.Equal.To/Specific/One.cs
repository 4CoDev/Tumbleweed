using Tumbleweed.Mathematics.Comparison.Boolean.Either.Is;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Envelope = Tumbleweed.Mathematics.Boolean.Envelope;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.X.Comparison.Is.Greater.Than.Or.Equal.To.Specific;

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