using DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.From.Abstract;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Mesh.Untransformed.Convex.Godot;

public sealed class Actual : Scalar::Envelope<Godot::ConvexPolygonShape3D>
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
		new One(
			new Abstract.Godot.Actual(collider))
	)
	{
	}
}