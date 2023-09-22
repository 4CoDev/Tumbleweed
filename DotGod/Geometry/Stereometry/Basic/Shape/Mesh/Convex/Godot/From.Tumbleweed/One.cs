using Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex;
using Enumerable = DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.With.Vertex.Whole.Enumerable;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.From.Tumbleweed;

public sealed class One : Scalar::Envelope<Godot::ConvexPolygonShape3D>
{
	public One(Any mesh) : base
	(
		new Enumerable(
			new global::Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.Member.Vertex.Whole.Enumerable(mesh))
	)
	{
	}
}