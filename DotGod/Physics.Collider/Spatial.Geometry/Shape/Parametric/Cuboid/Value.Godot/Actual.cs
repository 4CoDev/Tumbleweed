using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric.Cuboid.Value.Godot;

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
		new Scalar::Unboxed<Godot::BoxShape3D>(
			new Shape.Mesh.Untransformed.Convex.Godot.Actual(collider))
	)
	{
	}
}