using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Abstract.Godot;

public sealed class Actual : Scalar::Envelope<Godot::Shape3D>
{
	public Actual(Godot::CollisionShape3D collider) : this
	(
		new Scalar::With.Value
			<Godot::CollisionShape3D>
			(collider)
	)
	{
	}

	public Actual
	(
		Scalar::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new Scalar::Function.Result.Actual
			<Godot::Shape3D>
			(() => collider.Value.Shape)
	)
	{
	}
}