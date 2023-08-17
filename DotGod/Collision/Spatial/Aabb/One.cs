using Godot;
using Tumbleweed.Geometry.Spatial.Aabb;
using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Collision.Spatial.Aabb;

public sealed class One : Envelope
{
	public One(CollisionShape3D collider) : this
	(
		new Scalar::With.Value<CollisionShape3D>(collider)
	)
	{
	}
	
	public One(Any<CollisionShape3D> collider) : base
	(
		new Tumbleweed.Geometry.Spatial.Convex.Mesh.Aabb.One(
			new Mesh.Tumbleweed.Convex.One(collider))
	)
	{
	}
}