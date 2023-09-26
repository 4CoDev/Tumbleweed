using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.X.Arithmetic.Difference.Absolute.Of;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;
using One = Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.Z.Arithmetic.Difference.Absolute.Of.One;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Distance;

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