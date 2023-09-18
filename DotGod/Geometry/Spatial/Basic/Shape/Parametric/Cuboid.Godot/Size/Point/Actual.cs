using Godot = Godot;
using TWPoint = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using DGPoint = DotGod.Point.Spatial;
using Size = DotGod.Geometry.Spatial.Basic.Shape.Parametric.Cuboid.Godot.Size;

namespace DotGod.Geometry.Spatial.Basic.Shape.Parametric.Cuboid.Godot.Size.Point;

public sealed class Actual : TWPoint::Generic.Envelope<Real::Any>
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
			new Size::Vector.Actual(cuboid))
	)
	{
	}
}