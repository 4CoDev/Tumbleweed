using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Spatial.Transform;

public sealed class TransformOfNode : Envelope<Transform3D>
{
	public TransformOfNode(Node3D node) : this
	(
		new Value<Node3D>(node)
	)
	{
	}
	
	public TransformOfNode(Any<Node3D> node) : base
	(
		new Actual<Transform3D>(
			() => node.Value.Transform)
	)
	{
	}
}