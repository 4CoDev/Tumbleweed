using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.ToGodot;
using Tumbleweed.Mutables;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Meshes;

public sealed class MutableOfNode : MutableEnvelope<IMesh>
{
	public MutableOfNode(MeshInstance3D node) : this
	(
		new ScalarValue<MeshInstance3D>(node)
	)
	{
	}

	public MutableOfNode(IScalar<MeshInstance3D> node) : base
	(
		new MutableWithMembers<IMesh>(
			() => Accessor(node),
			mesh => Mutator(node, mesh))
	)
	{
	}

	private static IMesh Accessor
	(
		IScalar<MeshInstance3D> node
	) =>
	(
		new MeshOfNode(node)
	);
	
	private static void Mutator
	(
		IScalar<MeshInstance3D> node,
		IMesh mesh
	)
	{
		node.Value.Mesh = new MeshFromTumbleweed(mesh).Value;
	}
}