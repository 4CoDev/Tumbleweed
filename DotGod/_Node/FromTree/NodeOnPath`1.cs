using DotGod._Node.Path.FromSystem;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Node.FromTree;

public sealed class NodeOnPath<T> : Envelope<T> where T : Node
{
	public NodeOnPath(Node relation, String path) : this
	(
		new Value<Node>(relation),
		path
	)
	{
	}
	
	public NodeOnPath(Any<Node> relation, String path) : this
	(
		relation, new Value<String>(path)
	)
	{
	}
	
	public NodeOnPath(Any<Node> relation, Any<String> path) : this
	(
		relation, new PathFromString(path)
	)
	{
	}
	
	public NodeOnPath(Any<Node> relation, NodePath path) : this
	(
		relation, new Value<NodePath>(path)
	)
	{
	}
	
	public NodeOnPath
	(
		Any<Node> relation,
		Any<NodePath> path
	) : base
	(
		new Actual<T>(
			() => relation.Value.GetNode<T>(path.Value))
	)
	{
	}
}