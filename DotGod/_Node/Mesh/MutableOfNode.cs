using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.ToGodot;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Mutable;
using Tumbleweed.Scalar.Mutable.With;

namespace DotGod._Node.Mesh;

public sealed class MutableOfNode : Envelope<IMesh>
{
	public MutableOfNode(MeshInstance3D node) : this
	(
		new Tumbleweed.Scalar.Immutable.With.Value<MeshInstance3D>(node)
	)
	{
	}

	public MutableOfNode(Tumbleweed.Scalar.Immutable.Any<MeshInstance3D> node) : base
	(
		new Members<IMesh>(
			() => Accessor(node),
			mesh => Mutator(node, mesh))
	)
	{
	}

	private static IMesh Accessor
	(Tumbleweed.Scalar.Immutable.Any<MeshInstance3D> node
	) =>
	(
		new MeshOfNode(node)
	);
	
	private static void Mutator
	(Tumbleweed.Scalar.Immutable.Any<MeshInstance3D> node,
		IMesh mesh
	)
	{
		node.Value.Mesh = new MeshFromTumbleweed(mesh).Value;
	}
}