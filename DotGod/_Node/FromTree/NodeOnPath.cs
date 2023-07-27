using DotGod._Node.Path.FromSystem;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.FromTree;

public sealed class NodeOnPath : Envelope<Node>
{
	public NodeOnPath(Node relation, String path) : this
	(
		new Tumbleweed.Scalar.Of.Value<Node>(relation),
		path
	)
	{
	}
	
	public NodeOnPath(Any<Node> relation, String path) : this
	(
		relation,
		new Tumbleweed.Scalar.Of.Value<String>(path)
	)
	{
	}
	
	public NodeOnPath(Any<Node> relation, Any<String> path) : this
	(
		relation,
		new PathFromString(path)
	)
	{
	}
	
	public NodeOnPath(Any<Node> relation, NodePath path) : this
	(
		relation,
		new Tumbleweed.Scalar.Of.Value<NodePath>(path)
	)
	{
	}
	
	public NodeOnPath
	(
		Any<Node> relation,
		Any<NodePath> path
	) : base
	(
		new NodeOnPath<Node>(relation, path)
	)
	{
	}
}