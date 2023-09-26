using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;
using Multiple = Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Quotient.Scalar.Of.Point.Multiple;
using Real = Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Rounding.Nearest.As.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.Collided.By.Point.Index;

public sealed class One : Envelope<Mathematics.Number.Natural.Any>
{
	public One
	(
		Any aabb,
		Any<Mathematics.Number.Real.Any> point
	) : this
	(
		new Size.Whole.One(aabb),
		new Stereometry.Point.Real.Arithmetic.Difference.Just.Of.Multiple(
			point,
			new Actual(aabb))
	)
	{
	}

	public One
	(
		Any<Mathematics.Number.Real.Any> size,
		Any<Mathematics.Number.Real.Any> point
	) : base
	(
		new Stereometry.Point.Real.As.Natural.One(
			new Real(
				new Multiple(point, size)))
	)
	{
	}
}