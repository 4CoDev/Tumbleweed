using Godot;
using Tumbleweed.Geometry.Spatial.Aabb;
using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Collision.Collider.Spatial.Geometry.Aabb.Untransformed;

public sealed class Actual : Envelope
{
	public Actual(CollisionShape3D collider) : this
	(
		new Scalar::With.Value<CollisionShape3D>(collider)
	)
	{
	}
	
	public Actual(Any<CollisionShape3D> collider) : base
	(
		new Tumbleweed.Geometry.Spatial.Convex.Mesh.Aabb.One(
			new Mesh.Untransformed.Convex.Tumbleweed.Actual(collider))
	)
	{
	}
}