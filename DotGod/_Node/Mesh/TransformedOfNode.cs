using DotGod.Geometry.Spatial.Graphical._Mesh;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.Mesh;

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