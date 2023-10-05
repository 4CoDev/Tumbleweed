using Godot;
using Tumbleweed.Collection;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.Vertex.Godot.Enumerable;

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