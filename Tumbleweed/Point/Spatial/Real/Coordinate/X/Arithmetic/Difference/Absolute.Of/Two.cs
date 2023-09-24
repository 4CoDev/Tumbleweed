using Tumbleweed.Mathematics.Arithmetic.Real.Difference.Absolute.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Coordinate.X.Value;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.X.Arithmetic.Difference.Absolute.Of;

public sealed class Two : Envelope
{
	public Two
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Multiple(
			new One(first),
			new One(second))
	)
	{
	}
}