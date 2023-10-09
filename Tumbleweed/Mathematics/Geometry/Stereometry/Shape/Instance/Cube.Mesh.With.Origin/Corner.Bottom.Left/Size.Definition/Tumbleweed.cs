using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Instance.Cube.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition;

public sealed class Tumbleweed : Shape.Mesh.Convex.Envelope
{
	public Tumbleweed(Any size) : base
	(
		new Cuboid.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition.Tumbleweed(
			new Uniform(size))
	)
	{
	}
}