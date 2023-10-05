using DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size.Tumbleweed;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using ColliderParametric = DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric.Cuboid.Size;

public sealed class Tumbleweed : Envelope<Any>
{
	public Tumbleweed
	(
		Scalar::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new Actual(
			new ColliderParametric::Cuboid.Value.Godot.Actual(collider))
	)
	{
	}
}