using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;


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