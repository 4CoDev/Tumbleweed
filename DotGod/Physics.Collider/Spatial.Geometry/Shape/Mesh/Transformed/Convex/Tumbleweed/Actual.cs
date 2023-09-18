using Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using DGMesh = DotGod.Geometry.Spatial.Basic.Shape.Mesh.Convex;
using Node = DotGod.Node.Dimension.Spatial;

namespace DotGod.Physics.Collider.Spatial.Geometry.Shape.Mesh.Transformed.Convex.Tumbleweed;

public sealed class Actual : Envelope
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
			new Untransformed.Convex.Tumbleweed.Actual(collider),
			new Node::Transform.One(collider))
	)
	{
	}
}