using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using Object = Tumbleweed.Object;

namespace DotGod.Node.Node3D.CollisionShape3D.Shape.Specific.Origin.Parametric.Cuboid.Whole.Godot;

public sealed class Actual : Scalar::Envelope<Godot::BoxShape3D>
{
	public Actual
	(
		Godot::CollisionShape3D collider
	) : this
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
		new Object::Casted.Convertee.Object<Godot::BoxShape3D>(
			new CollisionShape3D.Shape.Abstract.Godot.Actual(collider))
	)
	{
	}
}