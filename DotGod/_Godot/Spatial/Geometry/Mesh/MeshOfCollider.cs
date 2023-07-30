using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Godot.Spatial.Geometry.Mesh;

public sealed class MeshOfCollider : Envelope<Shape3D>
{
	public MeshOfCollider(CollisionShape3D collider) : this
	(
		new Value<CollisionShape3D>(collider)
	)
	{
	}
	
	public MeshOfCollider(Any<CollisionShape3D> collider) : base
	(
		new Actual<Shape3D>(
			() => collider.Value.Shape)
	)
	{
	}
}