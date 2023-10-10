using DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.From.Tumbleweed;
using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;
using Tumbleweed.Scalar.Mutable;
using Tumbleweed.Scalar.Mutable.With;

namespace DotGod.Node.Node3D.VisualInstance3D.GeometryInstance3D.MeshInstance3D.Member.Mesh;

public sealed class Mutable : Envelope<Any>
{
	public Mutable(Godot.MeshInstance3D node) : this
	(
		new Tumbleweed.Scalar.Immutable.With.Value<Godot.MeshInstance3D>(node)
	)
	{
	}

	public Mutable(Tumbleweed.Scalar.Immutable.Any<Godot.MeshInstance3D> node) : base
	(
		new Members<Any>(
			() => Accessor(node),
			mesh => Mutator(node, mesh))
	)
	{
	}

	private static Any Accessor
	(Tumbleweed.Scalar.Immutable.Any<Godot.MeshInstance3D> node
	) =>
	(
		new Immutable.Untransformed.Tumbleweed(node)
	);
	
	private static void Mutator
	(Tumbleweed.Scalar.Immutable.Any<Godot.MeshInstance3D> node,
		Any mesh
	)
	{
		node.Value.Mesh = new One(mesh).Value;
	}
}