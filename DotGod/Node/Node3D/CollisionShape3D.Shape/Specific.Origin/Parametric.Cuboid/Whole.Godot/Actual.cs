using Tumbleweed.Scalar.Immutable.Casted.Convertee;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

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
		new Object<Godot::BoxShape3D>(
			new Origin.Mesh.Convex.As.Convex.Untransformed.Godot.Actual(collider))
	)
	{
	}
}