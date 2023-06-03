using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Transform;

public sealed class TransformOfNode : ScalarEnvelope<Transform3D>
{
	public TransformOfNode(Node3D node) : this
	(
		new ScalarValue<Node3D>(node)
	)
	{
	}
	
	public TransformOfNode(IScalar<Node3D> node) : base
	(
		new ResultOfFunction<Transform3D>(
			() => node.Value.Transform)
	)
	{
	}
}