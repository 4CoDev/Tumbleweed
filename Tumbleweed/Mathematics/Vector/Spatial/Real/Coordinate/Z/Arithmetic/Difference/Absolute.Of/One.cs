using Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Difference.Absolute.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Z.Arithmetic.Difference.Absolute.Of;

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