using Tumbleweed.Point.Spatial.Generic;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B.Actual;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.Both.Enumerable;

public sealed class One : Tumbleweed.Enumerable.Envelope<Any<Mathematics.Number.Real.Any>>
{
	public One(Any occupation) : base
	(
		new Enumerable::From.Array<Any<Mathematics.Number.Real.Any>>(
			new A.Actual(occupation),
			new Actual(occupation))
	)
	{
	}
}