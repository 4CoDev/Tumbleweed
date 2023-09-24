using Tumbleweed.Mathematics.Arithmetic.Real.Difference.Absolute.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y.Value;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Y.Arithmetic.Difference.Absolute.Of;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Multiple(
			new Value.One(first),
			new Value.One(second))
	)
	{
	}
}