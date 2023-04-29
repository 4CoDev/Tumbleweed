using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.Meshes.ToGodot;

public sealed class MeshOfNode : ScalarEnvelope<Mesh>
{
	public MeshOfNode(MeshInstance3D node) : this
	(
		new ScalarValue<MeshInstance3D>(node)
	)
	{
	}
	
	public MeshOfNode(IScalar<MeshInstance3D> node) : base
	(
		new ValueOfFunction<Mesh>(
			() => node.Value.Mesh)
	)
	{
	}
}