using DotGod._Node.BatchMap.Spatial.Spaces;
using DotGod.Spatial.Convex.Geometry.Mesh;
using DotGod.Spatial.Convex.Geometry.Mesh.Space;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Godot.Spatial.Geometry.Space;

public sealed class SpaceOfCollider : SpaceEnvelope
{
	public SpaceOfCollider(IScalar<CollisionShape3D> collider) : base
	(
		new SpaceFromMesh(
			new MeshOfCollider(collider))
	)
	{
	}
}