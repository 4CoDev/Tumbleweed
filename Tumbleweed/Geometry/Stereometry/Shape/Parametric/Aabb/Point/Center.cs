using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Quotient.Scalar.With.Number;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Sum.Scalar.Of;
using Actual = Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B.Actual;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Point;

public sealed class Center : Envelope<Tumbleweed.Number.Real.Any>
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