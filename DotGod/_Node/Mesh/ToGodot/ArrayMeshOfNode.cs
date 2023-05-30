using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.Mesh.ToGodot;

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