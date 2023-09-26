using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation;
using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Member.Vertex.Translation;

public sealed class Enumerable :
	Enumerable::Envelope<Any<Mathematics.Number.Real.Any>>
{
	public Enumerable(Any mesh) : base
	(
		new Multiple(
			new Whole.Enumerable(mesh))
  )
	{
	}
}