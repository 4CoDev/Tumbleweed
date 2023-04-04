using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Meshes;

public sealed class TransformedOfNode : MeshEnvelope
{
	public TransformedOfNode(MeshInstance3D node) : this
	(
		new ScalarValue<MeshInstance3D>(node)
	)
	{
	}
	
	public TransformedOfNode(IScalar<MeshInstance3D> node) : base
	(
		new TransformedMesh(
			new MeshOfNode(node),
			node.Value.Transform)
	)
	{
	}
}