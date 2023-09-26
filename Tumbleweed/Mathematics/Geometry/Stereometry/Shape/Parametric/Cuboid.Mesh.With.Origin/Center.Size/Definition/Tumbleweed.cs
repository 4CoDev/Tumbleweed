using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Half.Of;
using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Cuboid.Mesh.With.Origin.Center.Size.Definition;

public sealed class Tumbleweed : Shape.Mesh.Convex.Envelope
{
	public Tumbleweed
	(
		Any<Any> size
	) : base
	(
		new Shape.Mesh.Convex.Arithmetic.Translated.Backward.Scalar.With.Point.Real(
			new Corner.Bottom.Left.Size.Definition.Tumbleweed(size),
			new One(size))
	)
	{
	}
}