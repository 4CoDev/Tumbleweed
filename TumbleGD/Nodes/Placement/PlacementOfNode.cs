using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement;

public sealed class PlacementOfNode : INodePlacement
{
	public PlacementOfNode(Node node) : this
	(
		new ScalarOfValue<Node>(node)
	)
	{
	}
	
	public PlacementOfNode(IScalar<Node> node) =>
		this.node = node;

	public void Place(Node parent) =>
		parent.AddChild(node.Value);

	public void Remove() =>
		node.Value.GetParent().RemoveChild(node.Value);
	
	private readonly IScalar<Node> node;
}