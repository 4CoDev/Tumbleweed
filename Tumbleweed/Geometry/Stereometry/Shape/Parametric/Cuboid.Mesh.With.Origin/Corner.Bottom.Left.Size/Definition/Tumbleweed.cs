using Tumbleweed.Geometry.Stereometry.Shape.Parametric.Cube.Mesh.With.Origin.Corner.Bottom.Left.Literal;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Cuboid.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition;

public sealed class Tumbleweed : Shape.Mesh.Convex.Envelope
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