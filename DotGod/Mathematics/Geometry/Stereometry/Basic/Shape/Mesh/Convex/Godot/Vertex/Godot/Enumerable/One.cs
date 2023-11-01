using Godot;
using Tumbleweed.Collection;
using Tumbleweed.Collection.Function.Result;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.Vertex.Godot.Enumerable;

public sealed class One : global::Tumbleweed.Collection.Envelope<Vector3>
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
		new Actual<Vector3>(
			() => shape.Value.Points)
	)
	{
	}
}