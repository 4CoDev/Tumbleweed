using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;
using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.From.Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Node.Node3D.VisualInstance3D.GeometryInstance3D.MeshInstance3D.Member.Mesh.Immutable.Untransformed;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed(global::Godot.MeshInstance3D node) : this
	(
		new One<global::Godot.MeshInstance3D>(node)
	)
	{
	}

	public Tumbleweed(Any<global::Godot.MeshInstance3D> node) : base
	(
		new One(
			new Godot.Mesh(node))
	)
	{
	}
}