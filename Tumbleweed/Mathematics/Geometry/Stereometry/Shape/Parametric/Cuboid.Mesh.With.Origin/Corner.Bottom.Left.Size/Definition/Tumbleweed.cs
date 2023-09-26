using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Cube.Mesh.With.Origin.Corner.Bottom.Left.Literal;
using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Cuboid.Mesh.With.Origin.Corner.Bottom.Left.Size.Definition;

public sealed class Tumbleweed : Shape.Mesh.Convex.Envelope
{
	public Tumbleweed
	(
		Any<Any> size
	) : base
	(
		new Shape.Mesh.Convex.Arithmetic.Scaled.Up.Scalar.With.Point.Real(
			 new Unit(),
			 size)
	)
	{
	}
}