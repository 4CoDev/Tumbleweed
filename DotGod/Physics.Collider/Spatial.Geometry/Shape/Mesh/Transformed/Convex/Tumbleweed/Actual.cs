using DotGod.Mathematics.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Tumbleweed.Transformed;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
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
		new One(
			new Untransformed.Convex.Tumbleweed.Actual(collider),
			new Node::Transform.One(collider))
	)
	{
	}
}