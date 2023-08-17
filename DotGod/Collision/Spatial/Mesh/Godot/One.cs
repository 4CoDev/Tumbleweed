using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Collision.Spatial.Mesh.Godot;

public sealed class One : Envelope<Shape3D>
{
	public One(CollisionShape3D collider) : this
	(
		new Value<CollisionShape3D>(collider)
	)
	{
	}
	
	public One(Any<CollisionShape3D> collider) : base
	(
		new Actual<Shape3D>(
			() => collider.Value.Shape)
	)
	{
	}
}