using DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.From.Tumbleweed;
using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;
using Godot;
using Tumbleweed.Scalar.Mutable;
using Tumbleweed.Scalar.Mutable.With;

namespace DotGod.Node.Dimension.Spatial.Mesh;

public sealed class Mutable : Envelope<Any>
{
	public Mutable(MeshInstance3D node) : this
	(
		new Tumbleweed.Scalar.Immutable.With.Value<MeshInstance3D>(node)
	)
	{
	}

	public Mutable(Tumbleweed.Scalar.Immutable.Any<MeshInstance3D> node) : base
	(
		new Members<Any>(
			() => Accessor(node),
			mesh => Mutator(node, mesh))
	)
	{
	}

	private static Any Accessor
	(Tumbleweed.Scalar.Immutable.Any<MeshInstance3D> node
	) =>
	(
		new Immutable.Untransformed.Tumbleweed(node)
	);
	
	private static void Mutator
	(Tumbleweed.Scalar.Immutable.Any<MeshInstance3D> node,
		Any mesh
	)
	{
		node.Value.Mesh = new One(mesh).Value;
	}
}