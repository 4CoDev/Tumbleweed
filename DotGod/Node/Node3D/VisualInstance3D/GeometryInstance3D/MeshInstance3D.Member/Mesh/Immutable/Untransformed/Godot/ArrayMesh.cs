using DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.From.Mesh;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Node.Node3D.VisualInstance3D.GeometryInstance3D.MeshInstance3D.Member.Mesh.Immutable.Untransformed.Godot;

public sealed class ArrayMesh : Envelope<global::Godot.ArrayMesh>
{
	public ArrayMesh(global::Godot.MeshInstance3D node) : this
	(
		new One<global::Godot.MeshInstance3D>(node)
	)
	{
	}
	
	public ArrayMesh(Any<global::Godot.MeshInstance3D> node) : base
	(
		new One(
			new Mesh(node))
	)
	{
	}
}