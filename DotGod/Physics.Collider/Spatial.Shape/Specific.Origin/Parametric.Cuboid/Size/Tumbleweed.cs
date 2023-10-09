using DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size.Tumbleweed;
using Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Physics.Collider.Spatial.Shape.Specific.Origin.Parametric.Cuboid.Size;

public sealed class Tumbleweed : global::Tumbleweed.Mathematics.Vector.Spatial.Generic.Envelope<Any>
{
	public Tumbleweed
	(
		Scalar::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new Actual(
			new Whole.Godot.Actual(collider))
	)
	{
	}
}