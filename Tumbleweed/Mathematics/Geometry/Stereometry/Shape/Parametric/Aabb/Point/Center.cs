using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Quotient.Scalar.With.Number;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Sum.Scalar.Of;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B.Actual;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point;

public sealed class Center : Envelope<Mathematics.Number.Real.Any>
{
	public Center(Any space) : base
	(
		new Real(
			new Multiple(
				new Actual(space),
				new Point.A.Actual(space)),
			2)
	)
	{
	}
}