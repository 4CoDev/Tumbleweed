using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.ToGodot;
using Godot;
using Tumbleweed.Mutable;
using Tumbleweed.Mutable.With;
using Tumbleweed.Scalar;

namespace DotGod._Node.Mesh;

public sealed class MutableOfNode : Tumbleweed.Mutable.Envelope<IMesh>
{
	public MutableOfNode(MeshInstance3D node) : this
	(
		new Tumbleweed.Scalar.Of.Value<MeshInstance3D>(node)
	)
	{
	}

	public MutableOfNode(Tumbleweed.Scalar.Any<MeshInstance3D> node) : base
	(
		new Members<IMesh>(
			() => Accessor(node),
			mesh => Mutator(node, mesh))
	)
	{
	}

	private static IMesh Accessor
	(Tumbleweed.Scalar.Any<MeshInstance3D> node
	) =>
	(
		new MeshOfNode(node)
	);
	
	private static void Mutator
	(Tumbleweed.Scalar.Any<MeshInstance3D> node,
		IMesh mesh
	)
	{
		node.Value.Mesh = new MeshFromTumbleweed(mesh).Value;
	}
}