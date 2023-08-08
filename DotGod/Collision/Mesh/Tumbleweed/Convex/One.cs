using Godot;
using Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Collision.Mesh.Tumbleweed.Convex;

public sealed class One : Envelope
{
	public One(CollisionShape3D collider) : this
	(
		new Value<CollisionShape3D>(collider)
	)
	{
	}
	
	public One(Any<CollisionShape3D> collider) : base
	(
		new Geometry.Spatial.Convex.Physical.Mesh.Tumbleweed.From.Godot.One(
			new Godot.One(collider))
	)
	{
	}
}