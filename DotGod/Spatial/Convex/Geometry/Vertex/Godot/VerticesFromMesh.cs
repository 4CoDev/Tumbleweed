using Godot;
using Tumbleweed.Collection;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Convex.Geometry.Vertex.Godot;

public sealed class VerticesFromMesh : CollectionEnvelope<Vector3>
{
	public VerticesFromMesh(ConvexPolygonShape3D shape) : this
	(
		new Tumbleweed.Scalar.Of.Value<ConvexPolygonShape3D>(shape)
	)
	{
	}
	
	public VerticesFromMesh
	(
		Any<ConvexPolygonShape3D> shape
	) : base
	(
		new CollectionOfFunction<Vector3>(
			() => shape.Value.Points)
	)
	{
	}
}