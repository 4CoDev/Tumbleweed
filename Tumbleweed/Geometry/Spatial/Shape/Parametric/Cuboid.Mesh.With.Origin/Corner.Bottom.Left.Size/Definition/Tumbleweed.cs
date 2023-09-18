using Tumbleweed.Geometry.Spatial.Shape.Parametric.Cube.Mesh.With.Origin.Corner.Bottom.Left.Literal;
using Envelope = Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Envelope;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Shape.Parametric.Cuboid.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed
	(
		Point::Generic.Any<Real::Any> size
	) : base
	(
		new Shape.Mesh.Convex.Arithmetic.Scaled.Up.Scalar.With.Point.Real(
			 new Unit(),
			 size)
	)
	{
	}
}