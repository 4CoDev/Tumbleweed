using Godot;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Parametric.Cuboid.Godot.Size.Godot;

public sealed class Actual : Property::Envelope<Vector3>
{
	public Actual(BoxShape3D cuboid) : this
	(
		new Property::With.Value<BoxShape3D>(cuboid)
	)
	{
	}
	
	public Actual
	(
		Property::Any<BoxShape3D> cuboid
	) : base
	(
		new Property::Function.Result.Actual<Vector3>(
			() => cuboid.Value.Size)
	)
	{
	}
}