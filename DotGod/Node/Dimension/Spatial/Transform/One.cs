using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Dimension.Spatial.Transform;

public sealed class One : Envelope<Transform3D>
{
	public One(Node3D node) : this
	(
		new Value<Node3D>(node)
	)
	{
	}
	
	public One(Any<Node3D> node) : base
	(
		new Actual<Transform3D>(
			() => node.Value.Transform)
	)
	{
	}
}