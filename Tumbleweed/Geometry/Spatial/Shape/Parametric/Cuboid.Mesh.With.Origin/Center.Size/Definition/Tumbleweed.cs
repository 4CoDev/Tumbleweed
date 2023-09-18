using Envelope = Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Envelope;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Shape.Parametric.Cuboid.Mesh.With.Origin.Center.Size.Definition;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed
	(
		Point::Generic.Any<Real::Any> size
	) : base
	(
		new Shape.Mesh.Convex.Arithmetic.Translated.Backward.Scalar.With.Point.Real(
			new Corner.Bottom.Left.Size.Definition.Tumbleweed(size),
			new Point::Real.Arithmetic.Half.Of.One(size))
	)
	{
	}
}