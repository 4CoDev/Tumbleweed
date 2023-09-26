using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.Z.Arithmetic.Negation.Of;

public sealed class One : Envelope
{
	public One(Any<Any> point) : base
	(
		new Mathematics.Arithmetic.Real.Negation.Of.One(
			new Coordinate.Z.Value.One(point)))
	{
	}
}