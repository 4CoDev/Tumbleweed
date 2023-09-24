using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Cube.Mesh.With.Origin.Center.Literal;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed() : base
	(
		new Cuboid.Mesh.With.Origin.Center.Size.Definition.Tumbleweed(
			new Point::Real.Literal.Unit())
	)
	{
	}
}