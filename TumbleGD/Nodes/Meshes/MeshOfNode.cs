using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Geometrics.Graphical.Meshes.FromArrayMeshes.FromGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Meshes;

public sealed class MeshOfNode : MeshEnvelope
{
	public MeshOfNode(MeshInstance3D node) : this
	(
		new ScalarValue<MeshInstance3D>(node)
	)
	{
	}

	public MeshOfNode(IScalar<MeshInstance3D> node) : base
	(
		new MeshFromGodot(
			new ToGodot.MeshOfNode(node))
	)
	{
	}
}