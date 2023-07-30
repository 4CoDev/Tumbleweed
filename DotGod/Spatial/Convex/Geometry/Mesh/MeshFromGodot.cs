using DotGod._Godot.Spatial.Convex.Geometry.Mesh;
using DotGod.Spatial.Convex.Geometry.Vertex;
using Godot;
using Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Tumbleweed.Geometry.Spatial.Convex.Mesh.With;
using Tumbleweed.Geometry.Spatial.Convex.Mesh.With.Vertex.Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial.Convex.Geometry.Mesh;

public sealed class MeshFromGodot : Envelope
{
	public MeshFromGodot(Shape3D mesh) : this
	(
		new Value<Shape3D>(mesh)
	)
	{
	}
	
	public MeshFromGodot
	(
		Any<Shape3D> mesh
	) : this
	(
		new MeshFromAbstract(mesh)
	)
	{
	}
	
	public MeshFromGodot(ConvexPolygonShape3D mesh) : this
	(
		new Value<ConvexPolygonShape3D>(mesh)
	)
	{
	}
	
	public MeshFromGodot
	(
		Any<ConvexPolygonShape3D> mesh
	) : base
	(
		new One(
			new VerticesFromGodot(mesh))
	)
	{
	}
}