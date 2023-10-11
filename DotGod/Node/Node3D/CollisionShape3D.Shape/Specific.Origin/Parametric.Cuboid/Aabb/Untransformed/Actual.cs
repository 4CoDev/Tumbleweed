using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Parametric.Cuboid.Aabb.Untransformed;

public sealed class Actual : Aabb::Envelope
{
	public Actual
	(
		Godot::CollisionShape3D collider
	) : this
	(
		new Scalar::With.Value
			<Godot::CollisionShape3D>
			(collider)
	)
	{
	}
	
	public Actual
	(
		Scalar::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new Aabb::With.Size.At.Center.One(
			new Cuboid.Size.Tumbleweed(collider))
	)
	{
	}
}