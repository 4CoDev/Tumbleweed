using Mesh = Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Aabb;

public sealed class One : Parametric.Aabb.Envelope
{
	public One(Mesh::Any mesh) : base
	(
		new Spatial.Vertex.Enumerable.Aabb.One(
			new Member.Vertex.Whole.Enumerable(mesh))
	)
	{
	}
}