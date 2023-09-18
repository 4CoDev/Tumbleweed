using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Coordinate.X.Arithmetic.Difference.Absolute.Of;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y.Arithmetic.Difference.Absolute.Of;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z.Arithmetic.Difference.Absolute.Of;
using Tumbleweed.Point.Spatial.Real.With.Coordinate.Definition;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Z.Arithmetic.Difference.Absolute.Of.One;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Distance;

public sealed class L1 : Envelope<Any>
{
	public L1
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Unique(
			new Two(first, second),
			new Coordinate.Y.Arithmetic.Difference.Absolute.Of.One(first, second),
			new One(first, second))
	)
	{
	}
}