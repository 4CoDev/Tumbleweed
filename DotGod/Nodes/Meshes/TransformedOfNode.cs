using DotGod.Geometry.Graphical.Meshes;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.Meshes;

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