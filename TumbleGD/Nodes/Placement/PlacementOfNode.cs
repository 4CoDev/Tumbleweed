using Godot;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement;

public sealed class PlacementOfNode : PlacementEnvelope
{
	public PlacementOfNode(Node node) : this
	(
		new ScalarOfValue<Node>(node)
	)
	{
	}
	
	public PlacementOfNode(IScalar<Node> node) : base
	(
		new PlacementWithMembers(
			parent => parent.Value.AddChild(node.Value),
			() => node.Value.GetParent().RemoveChild(node.Value))
	)
	{
	}
}