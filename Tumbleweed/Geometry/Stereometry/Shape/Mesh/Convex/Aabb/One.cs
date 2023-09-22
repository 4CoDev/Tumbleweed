namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.Aabb;

public sealed class One : Parametric.Aabb.Envelope
{
	public One(Any mesh) : base
	(
		new Vertex.Enumerable.Aabb.One(
			new Member.Vertex.Whole.Enumerable(mesh))
	)
	{
	}
}