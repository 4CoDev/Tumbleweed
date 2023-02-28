using Godot;
using TumbleGD.Nodes.Paths.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.FromTree.OfGodot;

public sealed class NodeOnPath : ScalarEnvelope<Node>
{
	public NodeOnPath(Node relation, string path) : this
	(
		new ScalarOfValue<Node>(relation),
		path
	)
	{
	}
	
	public NodeOnPath(IScalar<Node> relation, string path) : this
	(
		relation, new ScalarOfValue<string>(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<Node> relation, IScalar<string> path) : this
	(
		relation, new PathFromString(path)
	)
	{
	}
	
	public NodeOnPath(IScalar<Node> relation, NodePath path) : this
	(
		relation, new ScalarOfValue<NodePath>(path)
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