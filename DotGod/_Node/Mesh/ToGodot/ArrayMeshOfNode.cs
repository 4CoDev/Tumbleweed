using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Node.Mesh.ToGodot;

public sealed class ArrayMeshOfNode : Envelope<ArrayMesh>
{
	public ArrayMeshOfNode(MeshInstance3D node) : this
	(
		new Value<MeshInstance3D>(node)
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