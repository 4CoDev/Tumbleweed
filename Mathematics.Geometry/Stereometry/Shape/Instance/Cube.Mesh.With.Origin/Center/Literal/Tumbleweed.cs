using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Tumbleweed.Mathematics.Vector.Spatial.Real.Literal;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Instance.Cube.Mesh.With.Origin.Center.Literal;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed() : base
	(
		new Cuboid.Mesh.With.Origin.Center.Size.Definition.Tumbleweed(
			new Unit())
	)
	{
	}
}