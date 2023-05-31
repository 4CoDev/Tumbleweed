using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Convex.Geometry.Mesh;
using GodotMeshOfCollider = DotGod._Godot.Spatial.Geometry.Mesh.MeshOfCollider;

namespace DotGod.Spatial.Convex.Geometry.Mesh;

public sealed class MeshOfCollider : MeshEnvelope
{
	public MeshOfCollider(CollisionShape3D collider) : this
	(
		new ScalarValue<CollisionShape3D>(collider)
	)
	{
	}
	
	public MeshOfCollider(IScalar<CollisionShape3D> collider) : base
	(
		new MeshFromGodot(
			new GodotMeshOfCollider(collider))
	)
	{
	}
}