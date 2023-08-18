using Tumbleweed.Geometry.Spatial.Vertex.Enumerable.Aabb;

namespace Tumbleweed.Geometry.Spatial.Convex.Mesh.Aabb;

public sealed class One : Spatial.Aabb.Envelope
{
	public One(global::Tumbleweed.Geometry.Spatial.Convex.Mesh.Any mesh) : base
	(
		new Spatial.Vertex.Enumerable.Aabb.One(
			new Member.Vertex.Enumerable(mesh))
	)
	{
	}
}