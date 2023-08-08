using Godot;
using Tumbleweed.Geometry.Spatial.Convex.Mesh;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using GodotMeshOfCollider = DotGod._Godot.Spatial.Geometry.Mesh.MeshOfCollider;

namespace DotGod.Geometry.Spatial.Convex.Geometry.Mesh;

public sealed class MeshOfCollider : Envelope
{
	public MeshOfCollider(CollisionShape3D collider) : this
	(
		new Value<CollisionShape3D>(collider)
	)
	{
	}
	
	public MeshOfCollider(Any<CollisionShape3D> collider) : base
	(
		new MeshFromGodot(
			new GodotMeshOfCollider(collider))
	)
	{
	}
}