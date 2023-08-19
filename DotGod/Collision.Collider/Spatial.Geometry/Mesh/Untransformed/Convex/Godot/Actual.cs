using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Untransformed =
	DotGod.Collision.Collider.Spatial.Geometry.Mesh.Untransformed;
using Mesh = DotGod.Geometry.Spatial.Convex.Physical.Mesh;

namespace DotGod.Collision.Collider.Spatial.Geometry.Mesh.Untransformed.Convex.Godot;

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
		new Mesh::Godot.From.Abstract.One(
			new Untransformed::Abstract.Godot.Actual(collider))
	)
	{
	}
}