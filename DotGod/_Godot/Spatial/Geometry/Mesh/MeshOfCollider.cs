using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod._Godot.Spatial.Geometry.Mesh;

public sealed class MeshOfCollider : Envelope<Shape3D>
{
	public MeshOfCollider(CollisionShape3D collider) : this
	(
		new Tumbleweed.Scalar.Of.Value<CollisionShape3D>(collider)
	)
	{
	}
	
	public MeshOfCollider(Any<CollisionShape3D> collider) : base
	(
		new Tumbleweed.Scalar.Function.Result<Shape3D>(
			() => collider.Value.Shape)
	)
	{
	}
}