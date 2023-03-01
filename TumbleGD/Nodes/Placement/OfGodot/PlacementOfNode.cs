using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement.OfGodot;

public sealed class PlacementOfNode : INodePlacement
{
	public PlacementOfNode(Node relation, Node node) : this
	(
		new ScalarOfValue<Node>(relation),
		new ScalarOfValue<Node>(node)
	)
	{
	}
	
	public PlacementOfNode
	(
		IScalar<Node> relation,
		IScalar<Node> node
	)
	{
		this.relation = relation;
		this.node = node;
	}

	public void Place() =>
		relation.Value.AddChild(node.Value);

	public void Remove() =>
		relation.Value.RemoveChild(node.Value);

	private readonly IScalar<Node> relation;

	private readonly IScalar<Node> node;
}