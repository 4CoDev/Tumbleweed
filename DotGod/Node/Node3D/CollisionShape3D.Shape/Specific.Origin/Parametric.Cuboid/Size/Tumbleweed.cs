using Vector = Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Number = Tumbleweed.Mathematics.Number;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using Cuboid = DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Parametric.Cuboid.Size;

public sealed class Tumbleweed : Vector::Envelope<Number::Real.Any>
{
	public Tumbleweed
	(
		Scalar::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new Cuboid::Godot.Size.Tumbleweed.Actual(
			new Whole.Godot.Actual(collider))
	)
	{
	}
}