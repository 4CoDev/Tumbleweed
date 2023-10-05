using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A.Actual;
using Multiple = Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Sum.Scalar.Of.Multiple;

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
			new Arithmetic.Vector.Spatial.Real.Product.Scalar.With.Point.Multiple(
				new Size.Half.One(space),
				new Vector.Spatial.Natural.As.Real.One(index)))
	)
	{
	}
}