using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Abstract.Godot;

public sealed class Actual : Property::Envelope<Godot::Shape3D>
{
	public Actual(Godot::CollisionShape3D collider) : this
	(
		new Property::With.Value
			<Godot::CollisionShape3D>
			(collider)
	)
	{
	}

	public Actual
	(
		Property::Any<Godot::CollisionShape3D> collider
	) : base
	(
		new Property::Function.Result.Actual
			<Godot::Shape3D>
			(() => collider.Value.Shape)
	)
	{
	}
}