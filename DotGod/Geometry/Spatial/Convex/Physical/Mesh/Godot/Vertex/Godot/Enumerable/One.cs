using Godot;
using Tumbleweed.Collection;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Spatial.Convex.Physical.Mesh.Godot.Vertex.Godot.Enumerable;

public sealed class One : CollectionEnvelope<Vector3>
{
	public One(ConvexPolygonShape3D shape) : this
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
		new CollectionOfFunction<Vector3>(
			() => shape.Value.Points)
	)
	{
	}
}