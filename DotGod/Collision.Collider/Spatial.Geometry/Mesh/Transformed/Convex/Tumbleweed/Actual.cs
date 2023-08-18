using TWMesh = Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using DGMesh = DotGod.Geometry.Spatial.Convex.Physical.Mesh;
using Untransformed = DotGod.Collision.Collider.Spatial.Geometry.Mesh.Untransformed;
using Node = DotGod.Node.Dimension.Spatial;

namespace DotGod.Collision.Collider.Spatial.Geometry.Mesh.Transformed.Convex.Tumbleweed;

public sealed class Actual : TWMesh::Envelope
{
	public Actual(Godot::CollisionShape3D collider) : this
	(
		new Scalar::With.Value<Godot::CollisionShape3D>(collider)
	)
	{
	}
	
	public Actual(Scalar::Any<Godot::CollisionShape3D> collider) : base
	(
		new DGMesh::Tumbleweed.Transformed.One(
			new Untransformed::Convex.Tumbleweed.Actual(collider),
			new Node::Transform.One(collider))
	)
	{
	}
}