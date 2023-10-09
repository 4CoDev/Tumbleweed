using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Half.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Instance.Cuboid.Mesh.With.Origin.Center.Size.Definition;

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