using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;
using Multiple = Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Sum.Scalar.Of.Multiple;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.At.Index.Point;

public sealed class A : Envelope<Mathematics.Number.Real.Any>
{
	public A
	(
		Any space,
		Any<Mathematics.Number.Natural.Any> index
	) : base
	(
		new Multiple(
			new Actual(space),
			new Stereometry.Point.Real.Arithmetic.Product.Scalar.With.Point.Multiple(
				new Size.Half.One(space),
				new Stereometry.Point.Natural.As.Real.One(index)))
	)
	{
	}
}