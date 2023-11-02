using DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.From.Tumbleweed;
using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;
using Tumbleweed.Property.Transput;
using Tumbleweed.Property.Transput.With;

namespace DotGod.Node.Node3D.VisualInstance3D.GeometryInstance3D.MeshInstance3D.Member.Mesh;

public sealed class Mutable : Envelope<Any>
{
	public Mutable(Godot.MeshInstance3D node) : this
	(
		new Tumbleweed.Property.Output.With.Value.One<Godot.MeshInstance3D>(node)
	)
	{
	}

	public Mutable(Tumbleweed.Property.Output.Any<Godot.MeshInstance3D> node) : base
	(
		new Members<Any>(
			() => Accessor(node),
			mesh => Mutator(node, mesh))
	)
	{
	}

	private static Any Accessor
	(Tumbleweed.Property.Output.Any<Godot.MeshInstance3D> node
	) =>
	(
		new Immutable.Untransformed.Tumbleweed(node)
	);
	
	private static void Mutator
	(Tumbleweed.Property.Output.Any<Godot.MeshInstance3D> node,
		Any mesh
	)
	{
		node.Value.Mesh = new One(mesh).Value;
	}
}