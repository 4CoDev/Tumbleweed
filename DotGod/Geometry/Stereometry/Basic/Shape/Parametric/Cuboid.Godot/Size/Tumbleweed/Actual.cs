using Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using DGPoint = DotGod.Point.Spatial;

namespace DotGod.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size.Tumbleweed;

public sealed class Actual : global::Tumbleweed.Mathematics.Vector.Spatial.Generic.Envelope<Any>
{
	public Actual(Godot::BoxShape3D cuboid) : this
	(
		new Scalar::With.Value<Godot::BoxShape3D>(cuboid)
	)
	{
	}
	
	public Actual
	(
		Scalar::Any<Godot::BoxShape3D> cuboid
	) : base
	(
		new DGPoint::From.Vector.One(
			new Godot.Actual(cuboid))
	)
	{
	}
}