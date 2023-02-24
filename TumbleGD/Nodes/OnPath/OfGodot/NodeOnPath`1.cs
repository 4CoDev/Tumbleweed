using Godot;
using TumbleGD.Nodes.Paths.FromSystem;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.OnPath.OfGodot;

public sealed class NodeOnPath<T> : ScalarEnvelope<T> where T : Node
{
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
		new ScalarOfDelegate<T>(
			() => relation.Value().GetNode<T>(path.Value()))
	)
	{
	}
}