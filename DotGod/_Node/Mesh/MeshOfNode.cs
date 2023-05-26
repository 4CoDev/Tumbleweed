using DotGod.Geometry.Spatial.Graphical._Mesh;
using DotGod.Geometry.Spatial.Graphical._Mesh.FromArrayMesh.FromGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.Mesh;

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