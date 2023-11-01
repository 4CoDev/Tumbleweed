using Godot;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Tumbleweed.From.Godot;

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
		new global::Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Whole.Enumerable.One(
			new Convex.Godot.Vertex.Tumbleweed.Enumerable.One(mesh))
	)
	{
	}
}