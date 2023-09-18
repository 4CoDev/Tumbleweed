using Godot;
using Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Spatial.Basic.Shape.Mesh.Convex.Tumbleweed.From.Godot;

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
		new Convex.Godot.From.Abstract.One(mesh)
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
		new global::Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.With.Vertex.Whole.Enumerable.One(
			new Convex.Godot.Vertex.Tumbleweed.Enumerable.One(mesh))
	)
	{
	}
}