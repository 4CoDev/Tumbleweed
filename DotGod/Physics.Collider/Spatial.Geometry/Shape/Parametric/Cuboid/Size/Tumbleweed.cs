using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Godot = Godot;

using Real = Tumbleweed.Mathematics.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using GeometryParametric = DotGod.Geometry.Stereometry.Basic.Shape.Parametric;
using ColliderParametric = DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric.Cuboid.Size;

public sealed class Tumbleweed : Envelope<Any>
{
	public Tumbleweed
	(
		Scalar::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new DotGod.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size
    .Tumbleweed.Actual(
			new ColliderParametric::Cuboid.Value.Godot.Actual(collider))
	)
	{
	}
}