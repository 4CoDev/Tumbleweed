using Envelope = Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Envelope;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Shape.Parametric.Cube.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed(Real::Any size) : base
	(
		new Cuboid.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition.Tumbleweed(
			new Point::Real.With.Coordinate.Definition.Uniform(size))
	)
	{
	}
}