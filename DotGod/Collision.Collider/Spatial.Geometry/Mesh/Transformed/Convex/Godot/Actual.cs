using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Mesh = DotGod.Geometry.Spatial.Convex.Physical.Mesh;
using Untransformed =
	DotGod.Collision.Collider.Spatial.Geometry.Mesh.Untransformed;

namespace DotGod.Collision.Collider.Spatial.Geometry.Mesh.Transformed.Convex.Godot;

public sealed class Actual : Scalar::Envelope<Godot::ConvexPolygonShape3D>
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
		new Mesh::Godot.From.Tumbleweed.One(
			new Untransformed::Convex.Tumbleweed.Actual(collider))
	)
	{
	}
}