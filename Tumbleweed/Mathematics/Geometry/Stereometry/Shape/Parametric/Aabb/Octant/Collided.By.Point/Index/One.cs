using Tumbleweed.Point.Spatial.Generic;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;
using Multiple = Tumbleweed.Point.Spatial.Real.Arithmetic.Quotient.Scalar.Of.Point.Multiple;
using Real = Tumbleweed.Point.Spatial.Real.Arithmetic.Rounding.Nearest.As.Real;

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
		new Tumbleweed.Point.Spatial.Real.Arithmetic.Difference.Just.Of.Multiple(
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
		new Mathematics.Number.Natural.Point.Spatial.From.Real(
			new Real(
				new Multiple(point, size)))
	)
	{
	}
}