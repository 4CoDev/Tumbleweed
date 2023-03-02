using Godot;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Existence.OfGodot;

public sealed class PlacementOfNode : ActionEnvelope
{
	public PlacementOfNode(Node parent, Node node) : this
	(
		new ScalarOfValue<Node>(parent),
		new ScalarOfValue<Node>(node)
	)
	{
	}
	
	public PlacementOfNode
	(
		IScalar<Node> parent,
		IScalar<Node> node
	) : base
	(
		new ActionFromSystem(
			() => Action(parent, node))
	)
	{
	}

	private static void Action
	(
		IScalar<Node> parent,
		IScalar<Node> node
	)
	{
		parent.Value.AddChild(node.Value);
	}
}