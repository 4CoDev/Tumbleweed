using Godot;
using Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Collision.Collider.Spatial.Geometry.Mesh.Untransformed.Convex.Tumbleweed;

public sealed class Actual : Envelope
{
	public Actual(CollisionShape3D collider) : this
	(
		new Value<CollisionShape3D>(collider)
	)
	{
	}
	
	public Actual(Any<CollisionShape3D> collider) : base
	(
		new DotGod.Geometry.Spatial.Convex.Physical.Mesh.Tumbleweed.From.Godot.One(
			new Abstract.Godot.Actual(collider))
	)
	{
	}
}