using Enumerable = Tumbleweed.Enumerable;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using Mesh = Tumbleweed.Geometry.Spatial.Convex.Mesh;

namespace Tumbleweed.Geometry.Spatial.Convex.Mesh.Member.Vertex;

public sealed class Enumerable : Enumerable::Envelope<Vertex::Any>
{
	public Enumerable(Mesh::Any mesh) : base
	(
		new Enumerable::Function.Result<Vertex::Any>(
			() => mesh.Vertices)
	)
	{
	}
}