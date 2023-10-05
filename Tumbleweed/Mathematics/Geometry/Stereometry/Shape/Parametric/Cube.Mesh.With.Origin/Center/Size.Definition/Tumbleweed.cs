using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;


namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Cube.Mesh.With.Origin.Center.Size.Definition;

public sealed class Tumbleweed : Shape.Mesh.Convex.Envelope
{
	public Tumbleweed(Any size) : base
	(
		new Cuboid.Mesh.With.Origin.Center.Size.Definition.Tumbleweed(
			new Uniform(size))
	)
	{
	}
}