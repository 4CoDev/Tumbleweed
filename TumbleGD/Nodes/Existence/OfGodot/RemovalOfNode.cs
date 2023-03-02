using Godot;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Existence.OfGodot;

public sealed class RemovalOfNode : ActionEnvelope
{
	public RemovalOfNode(Node node) : this
	(
		new ScalarOfValue<Node>(node)
	)
	{
	}
	
	public RemovalOfNode
	(
		IScalar<Node> node
	) : base
	(
		new ActionFromSystem(() => Action(node))
	)
	{
	}

	private static void Action(IScalar<Node> node) =>
		node.Value.Owner.RemoveChild(node.Value);
}