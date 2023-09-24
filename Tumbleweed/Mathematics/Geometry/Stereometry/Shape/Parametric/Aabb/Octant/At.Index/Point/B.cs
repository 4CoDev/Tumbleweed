using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Implementation.Real.From;
using Multiple = Tumbleweed.Point.Spatial.Real.Arithmetic.Sum.Scalar.Of.Multiple;

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
			new Tumbleweed.Point.Spatial.Real.Arithmetic.Product.Scalar.With.Point.Multiple(
				new Size.Half.One(space),
				new Natural(index)))
	)
	{
	}
}