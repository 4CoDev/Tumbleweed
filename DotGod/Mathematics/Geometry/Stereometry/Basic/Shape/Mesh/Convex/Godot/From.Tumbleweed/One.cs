using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Enumerable = DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Whole.Enumerable;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.From.Tumbleweed;

public sealed class One : Property::Envelope<Godot::ConvexPolygonShape3D>
{
	public One(Any mesh) : base
	(
		new Enumerable(
			new global::Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Member.Vertex.Whole.Enumerable(mesh))
	)
	{
	}
}