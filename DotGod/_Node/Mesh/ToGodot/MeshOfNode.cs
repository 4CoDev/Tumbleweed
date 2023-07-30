using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Node.Mesh.ToGodot;

public sealed class MeshOfNode : Envelope<Godot.Mesh>
{
	public MeshOfNode(MeshInstance3D node) : this
	(
		new Value<MeshInstance3D>(node)
	)
	{
	}
	
	public MeshOfNode(Any<MeshInstance3D> node) : base
	(
		new Actual<Godot.Mesh>(
			() => node.Value.Mesh)
	)
	{
	}
}