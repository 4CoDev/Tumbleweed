using Tumbleweed.Point.Spatial.Generic;
using Actual = Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;
using Multiple = Tumbleweed.Point.Spatial.Real.Arithmetic.Quotient.Scalar.Of.Point.Multiple;
using Real = Tumbleweed.Point.Spatial.Real.Arithmetic.Rounding.Nearest.As.Real;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.Collided.By.Point.Index;

public sealed class One : Envelope<Tumbleweed.Number.Natural.Any>
{
	public One
	(
		Any aabb,
		Any<Tumbleweed.Number.Real.Any> point
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
		Any<Tumbleweed.Number.Real.Any> size,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new Number.Natural.Point.Spatial.From.Real(
			new Real(
				new Multiple(point, size)))
	)
	{
	}
}