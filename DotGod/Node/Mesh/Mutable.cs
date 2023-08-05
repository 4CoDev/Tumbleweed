using DotGod.Node.Mesh.Immutable.Untransformed;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.ToGodot;
using Godot;
using Tumbleweed.Scalar.Mutable;
using Tumbleweed.Scalar.Mutable.With;

namespace DotGod.Node.Mesh;

public sealed class Mutable : Envelope<IMesh>
{
	public Mutable(MeshInstance3D node) : this
	(
		new Tumbleweed.Scalar.Immutable.With.Value<MeshInstance3D>(node)
	)
	{
	}

	public Mutable(Tumbleweed.Scalar.Immutable.Any<MeshInstance3D> node) : base
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
		new Immutable.Untransformed.Tumbleweed(node)
	);
	
	private static void Mutator
	(Tumbleweed.Scalar.Immutable.Any<MeshInstance3D> node,
		IMesh mesh
	)
	{
		node.Value.Mesh = new MeshFromTumbleweed(mesh).Value;
	}
}