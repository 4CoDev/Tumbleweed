using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.Mesh.ToGodot;

public sealed class ArrayMeshOfNode : Envelope<ArrayMesh>
{
	public ArrayMeshOfNode(MeshInstance3D node) : this
	(
		new Tumbleweed.Scalar.Of.Value<MeshInstance3D>(node)
	)
	{
	}
	
	public ArrayMeshOfNode(Any<MeshInstance3D> node) : base
	(
		new ArrayMeshFromMesh(
			new MeshOfNode(node))
	)
	{
	}
}