using Enumerable = Tumbleweed.Enumerable;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Member.Vertex.Whole;

public sealed class Enumerable : Enumerable::Envelope<Vertex::Any>
{
	public Enumerable(Any mesh) : base
	(
		new Enumerable::Function.Result<Vertex::Any>(
			() => mesh.Vertices)
	)
	{
	}
}