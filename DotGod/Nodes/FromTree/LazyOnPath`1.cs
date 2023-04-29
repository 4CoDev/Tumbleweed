using DotGod.Nodes.Paths.FromSystem;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.FromTree;

public sealed class LazyOnPath<T> : ScalarEnvelope<T> where T : Node
{
	public LazyOnPath(Node relation, String path) : this
	(
		new ScalarValue<Node>(relation),
		path
	)
	{
	}
	
	public LazyOnPath(IScalar<Node> relation, String path) : this
	(
		relation, new ScalarValue<String>(path)
	)
	{
	}
	
	public LazyOnPath(IScalar<Node> relation, IScalar<String> path) : this
	(
		relation, new PathFromString(path)
	)
	{
	}
	
	public LazyOnPath(IScalar<Node> relation, NodePath path) : this
	(
		relation, new ScalarValue<NodePath>(path)
	)
	{
	}
	
	public LazyOnPath
	(
		IScalar<Node> relation,
		IScalar<NodePath> path
	) : base
	(
		new LazyValue<T>(
			new NodeOnPath<T>(relation, path))
	)
	{
	}
}