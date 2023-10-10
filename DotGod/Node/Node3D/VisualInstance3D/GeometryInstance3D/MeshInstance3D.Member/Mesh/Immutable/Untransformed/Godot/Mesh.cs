using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Node3D.VisualInstance3D.GeometryInstance3D.MeshInstance3D.Member.Mesh.Immutable.Untransformed.Godot;

public sealed class Mesh : Envelope<global::Godot.Mesh>
{
	public Mesh(global::Godot.MeshInstance3D node) : this
	(
		new Value<global::Godot.MeshInstance3D>(node)
	)
	{
	}
	
	public Mesh(Any<global::Godot.MeshInstance3D> node) : base
	(
		new Actual<global::Godot.Mesh>(
			() => node.Value.Mesh)
	)
	{
	}
}