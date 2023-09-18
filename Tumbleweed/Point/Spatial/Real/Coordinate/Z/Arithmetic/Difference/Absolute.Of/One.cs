using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Arithmetic.Difference.Absolute.Of;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z.Value;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Z.Arithmetic.Difference.Absolute.Of;

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