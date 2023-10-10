using DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.From.Mesh;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Node3D.VisualInstance3D.GeometryInstance3D.MeshInstance3D.Member.Mesh.Immutable.Untransformed.Godot;

public sealed class ArrayMesh : Envelope<global::Godot.ArrayMesh>
{
	public ArrayMesh(global::Godot.MeshInstance3D node) : this
	(
		new Value<global::Godot.MeshInstance3D>(node)
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