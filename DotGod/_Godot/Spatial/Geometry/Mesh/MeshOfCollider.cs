using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Godot.Spatial.Geometry.Mesh;

public sealed class MeshOfCollider : ScalarEnvelope<Shape3D>
{
	public MeshOfCollider(CollisionShape3D collider) : this
	(
		new ScalarValue<CollisionShape3D>(collider)
	)
	{
	}
	
	public MeshOfCollider(IScalar<CollisionShape3D> collider) : base
	(
		new ResultOfFunction<Shape3D>(
			() => collider.Value.Shape)
	)
	{
	}
}