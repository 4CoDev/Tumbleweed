using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Spatial._Node.Transform;

public sealed class TransformOfNode : Envelope<Transform3D>
{
	public TransformOfNode(Node3D node) : this
	(
		new Tumbleweed.Scalar.Of.Value<Node3D>(node)
	)
	{
	}
	
	public TransformOfNode(Any<Node3D> node) : base
	(
		new Tumbleweed.Scalar.Function.Result<Transform3D>(
			() => node.Value.Transform)
	)
	{
	}
}