using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Cube.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition;

public sealed class Tumbleweed : Shape.Mesh.Convex.Envelope
{
	public Tumbleweed(Real::Any size) : base
	(
		new Cuboid.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition.Tumbleweed(
			new Point::Real.With.Coordinate.Definition.Uniform(size))
	)
	{
	}
}