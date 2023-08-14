using DotGod.Collision.Mesh.Tumbleweed.Convex;
using Godot;
using Tumbleweed.Geometry.Spatial.Aabb;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Collision.Space;

public sealed class One : Envelope
{
	public One(Any<CollisionShape3D> collider) : base
	(
		new Tumbleweed.Geometry.Spatial.Convex.Mesh.Aabb.One(
			new Mesh.Tumbleweed.Convex.One(collider))
	)
	{
	}
}