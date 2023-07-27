using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial.Convex.Geometry.Mesh;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Godot.Spatial.Geometry.Space;

public sealed class SpaceOfCollider : SpaceEnvelope
{
	public SpaceOfCollider(Any<CollisionShape3D> collider) : base
	(
		new SpaceFromMesh(
			new MeshOfCollider(collider))
	)
	{
	}
}