using DotGod._Node.Path.FromSystem;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.FromTree;

public sealed class NodeOnPath : ScalarEnvelope<Node>
{
	public NodeOnPath(Node relation, String path) : this
	(
		new ScalarValue<Node>(relation),
		path
	)
	{
	}
	
	public NodeOnPath(IScalar<Node> relation, String path) : this
	(
		relation,
		new ScalarValue<String>(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<Node> relation, IScalar<String> path) : this
	(
		relation,
		new PathFromString(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<Node> relation, NodePath path) : this
	(
		relation,
		new ScalarValue<NodePath>(path)
	)
	{
	}
	
	public NodeOnPath
	(
		IScalar<Node> relation,
		IScalar<NodePath> path
	) : base
	(
		new NodeOnPath<Node>(relation, path)
	)
	{
	}
}