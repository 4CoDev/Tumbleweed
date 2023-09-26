using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point;
using Multiple = Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Sum.Scalar.Of.Multiple;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.At.Index.Point;

public sealed class B : Envelope<Mathematics.Number.Real.Any>
{
	public B
	(
		Any space,
		Any<Mathematics.Number.Natural.Any> index
	) : base
	(
		new Multiple(
			new Center(space),
			new Stereometry.Point.Real.Arithmetic.Product.Scalar.With.Point.Multiple(
				new Size.Half.One(space),
				new Stereometry.Point.Natural.As.Real.One(index)))
	)
	{
	}
}