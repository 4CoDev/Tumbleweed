using DotGod.Geometry.Spatial.Graphical.Meshes;
using DotGod.Geometry.Spatial.Graphical.Meshes.FromArrayMeshes.FromGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.Meshes;

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