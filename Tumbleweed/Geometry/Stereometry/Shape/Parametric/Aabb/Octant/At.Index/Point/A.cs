using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Implementation.Real.From;
using Actual = Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;
using Multiple = Tumbleweed.Point.Spatial.Real.Arithmetic.Sum.Scalar.Of.Multiple;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.At.Index.Point;

public sealed class A : Envelope<Tumbleweed.Number.Real.Any>
{
	public A
	(
		Any space,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new Multiple(
			new Actual(space),
			new Tumbleweed.Point.Spatial.Real.Arithmetic.Product.Scalar.With.Point.Multiple(
				new Size.Half.One(space),
				new Natural(index)))
	)
	{
	}
}