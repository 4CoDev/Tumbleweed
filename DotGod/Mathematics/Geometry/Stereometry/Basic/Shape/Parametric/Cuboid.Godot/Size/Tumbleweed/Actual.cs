using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using Number = Tumbleweed.Mathematics.Number;
using Godot = Godot;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size.Tumbleweed;

public sealed class Actual : Vector::Generic.Envelope<Number::Real.Any>
{
	public Actual(Godot::BoxShape3D cuboid) : this
	(
		new Property::With.Value.One<Godot::BoxShape3D>(cuboid)
	)
	{
	}
	
	public Actual
	(
		Property::Any<Godot::BoxShape3D> cuboid
	) : base
	(
		new DotGod.Mathematics.Vector.Spatial.Tumbleweed.From.Godot.One(
			new Godot.Actual(cuboid))
	)
	{
	}
}