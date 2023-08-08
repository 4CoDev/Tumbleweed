using DotGod.Geometry.Spatial.Convex.Physical.Vertex;
using Godot;
using Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Tumbleweed.From.Godot;

public sealed class One : Envelope
{
	public One(Shape3D mesh) : this
	(
		new Value<Shape3D>(mesh)
	)
	{
	}
	
	public One
	(
		Any<Shape3D> mesh
	) : this
	(
		new Mesh.Godot.From.Abstract.One(mesh)
	)
	{
	}
	
	public One(ConvexPolygonShape3D mesh) : this
	(
		new Value<ConvexPolygonShape3D>(mesh)
	)
	{
	}
	
	public One
	(
		Any<ConvexPolygonShape3D> mesh
	) : base
	(
		new global::Tumbleweed.Geometry.Spatial.Convex.Mesh.With.Vertex.Enumerable.One(
			new Mesh.Godot.Vertex.Tumbleweed.Enumerable.One(mesh))
	)
	{
	}
}