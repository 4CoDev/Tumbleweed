using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.Mesh.ToGodot;

public sealed class MeshOfNode : ScalarEnvelope<Godot.Mesh>
{
	public MeshOfNode(MeshInstance3D node) : this
	(
		new ScalarValue<MeshInstance3D>(node)
	)
	{
	}
	
	public MeshOfNode(IScalar<MeshInstance3D> node) : base
	(
		new ResultOfFunction<Godot.Mesh>(
			() => node.Value.Mesh)
	)
	{
	}
}