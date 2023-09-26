using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;

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