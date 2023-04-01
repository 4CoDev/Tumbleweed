using Godot;
using TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.OfGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Meshes.ToGodot;

public sealed class ArrayMeshOfNode : ScalarEnvelope<ArrayMesh>
{
	public ArrayMeshOfNode(MeshInstance3D node) : this
	(
		new ScalarValue<MeshInstance3D>(node)
	)
	{
	}
	
	public ArrayMeshOfNode(IScalar<MeshInstance3D> node) : base
	(
		new ArrayMeshFromMesh(
			new MeshOfNode(node))
	)
	{
	}
}