using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.Mesh;

public sealed class TransformedOfNode : MeshEnvelope
{
	public TransformedOfNode(MeshInstance3D node) : this
	(
		new Tumbleweed.Scalar.Of.Value<MeshInstance3D>(node)
	)
	{
	}
	
	public TransformedOfNode(Any<MeshInstance3D> node) : base
	(
		new TransformedMesh(
			new MeshOfNode(node),
			node.Value.Transform)
	)
	{
	}
}