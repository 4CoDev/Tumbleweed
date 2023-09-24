using Godot;
using Tumbleweed.Geometry.Stereometry.Vertex;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.Vertex.Tumbleweed.Enumerable;

public sealed class One : global::Tumbleweed.Enumerable.Envelope<Any>
{
	public One
	(
		ConvexPolygonShape3D shape
	) : this
	(
		new Value<ConvexPolygonShape3D>(shape)
	)
	{
	}
	
	public One
	(
		Any<ConvexPolygonShape3D> shape
	) : base
	(
		new global::Tumbleweed.Geometry.Stereometry.Vertex.With.Translation.Enumerable(
			new Point.Spatial.From.Vector.Enumerable(
				new Godot.Enumerable.One(shape)))
	)
	{
	}
}