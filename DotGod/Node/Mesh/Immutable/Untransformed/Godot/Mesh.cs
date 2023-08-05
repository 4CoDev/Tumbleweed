using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Mesh.Immutable.Untransformed.Godot;

public sealed class Mesh : Envelope<global::Godot.Mesh>
{
	public Mesh(MeshInstance3D node) : this
	(
		new Value<MeshInstance3D>(node)
	)
	{
	}
	
	public Mesh(Any<MeshInstance3D> node) : base
	(
		new Actual<global::Godot.Mesh>(
			() => node.Value.Mesh)
	)
	{
	}
}