using DotGod.Collision.Mesh.Tumbleweed.Convex;
using DotGod.Node.Batch.Dimension.Spatial.Space;
using Godot;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Collision.Space;

public sealed class One : Envelope
{
	public One(Any<CollisionShape3D> collider) : base
	(
		new Node.Batch.Dimension.Spatial.Space.Covering.Mesh.One(
			new Mesh.Tumbleweed.Convex.One(collider))
	)
	{
	}
}