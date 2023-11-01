using DotGod.Mathematics.Vector.Spatial.Tumbleweed.From.Godot;
using Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size.Tumbleweed;

public sealed class Actual : global::Tumbleweed.Mathematics.Vector.Spatial.Generic.Envelope<Any>
{
	public Actual(Godot::BoxShape3D cuboid) : this
	(
		new Property::With.Value<Godot::BoxShape3D>(cuboid)
	)
	{
	}
	
	public Actual
	(
		Property::Any<Godot::BoxShape3D> cuboid
	) : base
	(
		new One(
			new Godot.Actual(cuboid))
	)
	{
	}
}