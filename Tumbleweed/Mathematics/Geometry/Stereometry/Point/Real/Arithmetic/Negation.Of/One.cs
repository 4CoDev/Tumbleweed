using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Negation.Of;

public sealed class One : Envelope<Any>
{
	public One
	(
		Any<Any> point
	) : base
	(
		new Unique<Any>(
			new Coordinate.X.Arithmetic.Negation.Of.One(point),
			new Coordinate.Y.Arithmetic.Negation.Of.One(point),
			new Coordinate.Z.Arithmetic.Negation.Of.One(point))
	)
	{
	}
}