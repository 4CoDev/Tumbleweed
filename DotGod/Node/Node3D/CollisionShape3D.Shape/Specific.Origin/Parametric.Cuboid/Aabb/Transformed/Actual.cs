using TumbleweedAabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape
    .Parametric.Aabb;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using DotGodAabb = DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Parametric.Aabb;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Parametric.Cuboid.Aabb.Transformed;

public sealed class Actual : TumbleweedAabb::Envelope
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
		new DotGodAabb.Transformed.One(
			new Untransformed.Actual(collider),
			new Node3D.Member.Transform.One(collider))
	)
	{
	}
}