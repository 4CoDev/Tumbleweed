using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Aabb;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Parametric.Aabb.Untransformed;

public sealed class Actual : Envelope
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
		new One(
			new Shape.Mesh.Untransformed.Convex.Tumbleweed.Actual(collider))
	)
	{
	}
}