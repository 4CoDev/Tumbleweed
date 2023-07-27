using DotGod.Spatial.Convex.Geometry.Vertex.Godot;
using DotGod.Spatial.Vector.Point;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Geometry.Spatial.Vertex;
using Tumbleweed.Geometry.Spatial.Vertex.With.Translation;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Convex.Geometry.Vertex;

public sealed class VerticesFromGodot : Tumbleweed.Enumerable.Envelope<Any>
{
	public VerticesFromGodot
	(
		ConvexPolygonShape3D shape
	) : this
	(
		new Tumbleweed.Scalar.Of.Value<ConvexPolygonShape3D>(shape)
	)
	{
	}
	
	public VerticesFromGodot
	(
		Any<ConvexPolygonShape3D> shape
	) : base
	(
		new Multiple(
			new SpatialsFromVectors3(
				new VerticesFromMesh(shape)))
	)
	{
	}
}