using DotGod.Geometry.Graphical.Meshes;
using DotGod.Geometry.Graphical.Meshes.ArrayMeshes.ToGodot;
using Godot;
using Tumbleweed.Mutables;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.Meshes;

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