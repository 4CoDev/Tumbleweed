using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;
using Multiple = Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Quotient.Scalar.Of.Point.Multiple;
using Real = Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Rounding.Nearest.As.Real;

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
		new Arithmetic.Vector.Spatial.Real.Difference.Just.Of.Multiple(
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
		new Vector.Spatial.Real.As.Natural.One(
			new Real(
				new Multiple(point, size)))
	)
	{
	}
}