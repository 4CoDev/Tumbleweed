using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.X.Value.One;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Negation.Of;

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