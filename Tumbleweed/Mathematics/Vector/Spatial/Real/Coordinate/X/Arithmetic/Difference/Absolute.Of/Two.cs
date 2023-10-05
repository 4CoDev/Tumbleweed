using Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Difference.Absolute.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.X.Value;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.X.Arithmetic.Difference.Absolute.Of;

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