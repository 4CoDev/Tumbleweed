using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Coordinate.Z.Arithmetic.Half.Of;

public sealed class One : Envelope
{
	public One
	(
		Any<Any> point
	) : base
	(
		new Mathematics.Arithmetic.Real.Half.Of.One(
			new Value.One(point))
	)
	{
	}
}