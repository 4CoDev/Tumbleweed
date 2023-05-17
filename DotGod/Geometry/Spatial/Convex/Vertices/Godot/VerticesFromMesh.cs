using Godot;
using Tumbleweed.Collections;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Convex.Vertices.Godot;

public sealed class VerticesFromMesh : CollectionEnvelope<Vector3>
{
	public VerticesFromMesh(ConvexPolygonShape3D shape) : this
	(
		new ScalarValue<ConvexPolygonShape3D>(shape)
	)
	{
	}
	
	public VerticesFromMesh
	(
		IScalar<ConvexPolygonShape3D> shape
	) : base
	(
		new CollectionOfFunction<Vector3>(
			() => shape.Value.Points)
	)
	{
	}
}