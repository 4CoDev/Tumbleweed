using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;
using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.Transformed;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Node.Node3D.VisualInstance3D.GeometryInstance3D.MeshInstance3D.Member.Mesh.Immutable;

public sealed class Transformed : Envelope
{
	public Transformed(Godot.MeshInstance3D node) : this
	(
		new One<Godot.MeshInstance3D>(node)
	)
	{
	}
	
	public Transformed(Any<Godot.MeshInstance3D> node) : base
	(
		new One(
			new Untransformed.Tumbleweed(node),
			node.Value.Transform)
	)
	{
	}
}