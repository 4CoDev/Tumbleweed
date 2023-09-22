using DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Tumbleweed.From.Godot;
using Godot;
using Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Mesh.Untransformed.Convex.Tumbleweed;

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
		new One(
			new Abstract.Godot.Actual(collider))
	)
	{
	}
}