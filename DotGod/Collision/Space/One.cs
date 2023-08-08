using DotGod.Collision.Mesh.Tumbleweed.Convex;
using DotGod.Node.Spatial.Batch.Space;
using Godot;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Collision.Space;

public sealed class One : SpaceEnvelope
{
	public One(Any<CollisionShape3D> collider) : base
	(
		new SpaceFromMesh(
			new Mesh.Tumbleweed.Convex.One(collider))
	)
	{
	}
}