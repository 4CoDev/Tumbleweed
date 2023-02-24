using Godot;
using Tumbleweed.HashCodes;
using Tumbleweed.Scalars;
using Tumbleweed.Strings;

namespace TumbleGD.Nodes.Placement;

public sealed class PlacementOfNode : INodePlacement
{
	public PlacementOfNode(Node relation, Node node) : this
	(
		new ScalarOfValue<Node>(relation),
		new ScalarOfValue<Node>(node)
	)
	{
	}
	
	public PlacementOfNode(IScalar<Node> relation, IScalar<Node> node)
	{
		this.relation = relation;
		this.node = node;
	}
	
	public void Place() =>
		relation.Value.AddChild(node.Value);

	public void Remove() =>
		node.Value.QueueFree();

	public override int GetHashCode() =>
		new HashCodeFromObjects(relation, node).Value;

	public override string ToString() =>
		new StringFromObjects(relation, node).Value;

	private readonly IScalar<Node> relation;

	private readonly IScalar<Node> node;
}