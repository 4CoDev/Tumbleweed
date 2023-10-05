using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Negation.Of;

public sealed class One : Envelope<Any>
{
	public One
	(
		Any<Any> point
	) : base
	(
		new Unique<Any>(
			new Mathematics.Vector.Spatial.Real.Coordinate.X.Arithmetic.Negation.Of.One(point),
			new Mathematics.Vector.Spatial.Real.Coordinate.Y.Arithmetic.Negation.Of.One(point),
			new Mathematics.Vector.Spatial.Real.Coordinate.Z.Arithmetic.Negation.Of.One(point))
	)
	{
	}
}