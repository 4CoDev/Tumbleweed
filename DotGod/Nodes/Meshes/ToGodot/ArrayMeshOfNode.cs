using DotGod.Geometry.Spatial.Graphical.Meshes.ArrayMeshes.OfGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.Meshes.ToGodot;

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