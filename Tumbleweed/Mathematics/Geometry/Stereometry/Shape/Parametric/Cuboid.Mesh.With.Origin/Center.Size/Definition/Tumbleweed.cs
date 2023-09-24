using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Cuboid.Mesh.With.Origin.Center.Size.Definition;

public sealed class Tumbleweed : Shape.Mesh.Convex.Envelope
{
	public Tumbleweed
	(
		Point::Generic.Any<Any> size
	) : base
	(
		new Shape.Mesh.Convex.Arithmetic.Translated.Backward.Scalar.With.Point.Real(
			new Corner.Bottom.Left.Size.Definition.Tumbleweed(size),
			new Point::Real.Arithmetic.Half.Of.One(size))
	)
	{
	}
}