using DotGod._Node.Path.FromSystem;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Node.FromTree;

public sealed class LazyOnPath<T> : Envelope<T> where T : Node
{
	public LazyOnPath(Node relation, String path) : this
	(
		new Value<Node>(relation),
		path
	)
	{
	}
	
	public LazyOnPath(Any<Node> relation, String path) : this
	(
		relation, new Value<String>(path)
	)
	{
	}
	
	public LazyOnPath(Any<Node> relation, Any<String> path) : this
	(
		relation, new PathFromString(path)
	)
	{
	}
	
	public LazyOnPath(Any<Node> relation, NodePath path) : this
	(
		relation, new Value<NodePath>(path)
	)
	{
	}
	
	public LazyOnPath
	(
		Any<Node> relation,
		Any<NodePath> path
	) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<T>(
			new NodeOnPath<T>(relation, path))
	)
	{
	}
}