using Godot;
using Tumbleweed.Geometry.Spatial.Vertex;
using Tumbleweed.Geometry.Spatial.Vertex.With.Translation;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot.Vertex.Tumbleweed.Enumerable;

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
		new Multiple(
			new Point.Spatial.From.Vector.Enumerable(
				new Godot.Enumerable.One(shape)))
	)
	{
	}
}