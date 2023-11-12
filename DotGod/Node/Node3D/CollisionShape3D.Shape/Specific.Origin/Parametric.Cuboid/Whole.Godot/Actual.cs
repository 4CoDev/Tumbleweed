using Godot;
using Godot = Godot;
using Property = Tumbleweed.Property.Output;
using Object = Tumbleweed.Object;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Parametric.Cuboid.Whole.Godot;

public sealed class Actual : Property::Envelope<Godot::BoxShape3D>
{
	public Actual
	(
		Godot::CollisionShape3D collider
	) : this
	(
		new Property::With.Value.One
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
		new Object::Casted.Convertee.Object<Godot::BoxShape3D>(
			new CollisionShape3D.Shape.Abstract.Godot.Actual(collider))
	)
	{
	}
}