using Godot;
using Tumbleweed._Collection;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Convex.Geometry.Vertex.Godot;

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