using Godot;
using TumbleGD.Nodes.Paths.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.FromTree;

public sealed class NodeOnPath<T> : ScalarEnvelope<T> where T : Node
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
		relation, new ScalarValue<String>(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<Node> relation, IScalar<String> path) : this
	(
		relation, new PathFromString(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<Node> relation, NodePath path) : this
	(
		relation, new ScalarValue<NodePath>(path)
	)
	{
	}
	
	public NodeOnPath
	(
		IScalar<Node> relation,
		IScalar<NodePath> path
	) : base
	(
		new ValueOfFunction<T>(
			() => relation.Value.GetNode<T>(path.Value))
	)
	{
	}
}