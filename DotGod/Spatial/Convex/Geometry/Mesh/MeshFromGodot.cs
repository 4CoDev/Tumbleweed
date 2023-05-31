using DotGod._Godot.Spatial.Convex.Geometry.Mesh;
using DotGod.Spatial.Convex.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Convex.Geometry.Mesh;

namespace DotGod.Spatial.Convex.Geometry.Mesh;

public sealed class MeshFromGodot : MeshEnvelope
{
	public MeshFromGodot(Shape3D mesh) : this
	(
		new ScalarValue<Shape3D>(mesh)
	)
	{
	}
	
	public MeshFromGodot
	(
		IScalar<Shape3D> mesh
	) : this
	(
		new MeshFromAbstract(mesh)
	)
	{
	}
	
	public MeshFromGodot(ConvexPolygonShape3D mesh) : this
	(
		new ScalarValue<ConvexPolygonShape3D>(mesh)
	)
	{
	}
	
	public MeshFromGodot
	(
		IScalar<ConvexPolygonShape3D> mesh
	) : base
	(
		new MeshWithVertices(
			new VerticesFromGodot(mesh))
	)
	{
	}
}