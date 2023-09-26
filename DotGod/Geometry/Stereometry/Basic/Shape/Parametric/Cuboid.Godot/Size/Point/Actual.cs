using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;
using TWPoint = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using Real = Tumbleweed.Mathematics.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using DGPoint = DotGod.Point.Spatial;

namespace DotGod.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size.Point;

public sealed class Actual : Envelope<Any>
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
			new Vector.Actual(cuboid))
	)
	{
	}
}