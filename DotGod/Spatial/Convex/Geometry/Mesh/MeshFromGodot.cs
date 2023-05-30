using DotGod.Spatial.Convex.Geometry.Mesh.Vertex;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Convex.Geometry.Mesh;

namespace DotGod.Spatial.Convex.Geometry.Mesh;

public sealed class MeshFromGodot : MeshEnvelope
{
	public MeshFromGodot(ConvexPolygonShape3D shape) : this
	(
		new ScalarValue<ConvexPolygonShape3D>(shape)
	)
	{
	}
	
	public MeshFromGodot
	(
		IScalar<ConvexPolygonShape3D> shape
	) : base
	(
		new MeshWithVertices(
			new VerticesFromGodot(shape))
	)
	{
	}
}