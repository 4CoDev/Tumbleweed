using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Quotient.Scalar.With.Number;
using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Sum.Scalar.Of;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
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