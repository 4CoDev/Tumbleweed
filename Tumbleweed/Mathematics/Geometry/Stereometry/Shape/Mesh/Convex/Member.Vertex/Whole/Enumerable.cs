using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Member.Vertex.Whole;

public sealed class Enumerable : Enumerable::Envelope<Stereometry.Vertex.Any>
{
	public Enumerable(Any mesh) : base
	(
		new Enumerable::Function.Result<Stereometry.Vertex.Any>(
			() => mesh.Vertices)
	)
	{
	}
}