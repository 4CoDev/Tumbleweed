using Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Basic.Shape.Parametric.Cuboid.Godot.Size.Vector;

public sealed class Actual : Scalar::Envelope<Vector3>
{
	public Actual(BoxShape3D cuboid) : this
	(
		new Scalar::With.Value<BoxShape3D>(cuboid)
	)
	{
	}
	
	public Actual
	(
		Scalar::Any<BoxShape3D> cuboid
	) : base
	(
		new Scalar::Function.Result.Actual<Vector3>(
			() => cuboid.Value.Size)
	)
	{
	}
}