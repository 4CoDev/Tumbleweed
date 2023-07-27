using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod._Node.Mesh.ToGodot;

public sealed class MeshOfNode : Envelope<Godot.Mesh>
{
	public MeshOfNode(MeshInstance3D node) : this
	(
		new Tumbleweed.Scalar.Of.Value<MeshInstance3D>(node)
	)
	{
	}
	
	public MeshOfNode(Any<MeshInstance3D> node) : base
	(
		new Tumbleweed.Scalar.Function.Result<Godot.Mesh>(
			() => node.Value.Mesh)
	)
	{
	}
}