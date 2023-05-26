using DotGod._Node.Path.FromSystem;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.FromTree;

public sealed class LazyOnPath : ScalarEnvelope<Node>
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
		new LazyOnPath<Node>(relation, path)
	)
	{
	}
}