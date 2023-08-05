using DotGod.Spatial.Convex.Geometry.Vertex.Godot;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Geometry.Spatial.Vertex;
using Tumbleweed.Geometry.Spatial.Vertex.With.Translation;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Enumerable = DotGod.Point.Spatial.From.Vector.Enumerable;

namespace DotGod.Spatial.Convex.Geometry.Vertex;

public sealed class VerticesFromGodot : Tumbleweed.Enumerable.Envelope<Any>
{
	public VerticesFromGodot
	(
		ConvexPolygonShape3D shape
	) : this
	(
		new Value<ConvexPolygonShape3D>(shape)
	)
	{
	}
	
	public VerticesFromGodot
	(
		Any<ConvexPolygonShape3D> shape
	) : base
	(
		new Multiple(
			new Enumerable(
				new VerticesFromMesh(shape)))
	)
	{
	}
}