using Godot;
using TumbleGD.Nodes.FromFiles.OfGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement.FromFiles.OfGodot;

public sealed class PlacementOfNode : PlacementEnvelope
{
	public PlacementOfNode(Node relation, string path) : this
	(
		new ScalarOfValue<Node>(relation),
		new ScalarOfValue<string>(path)
	)
	{
	}

	public PlacementOfNode
	(
		IScalar<Node> relation,
		IScalar<string> path
	) : base
	(
		new Placement.OfGodot.PlacementOfNode(
			relation,
			new NodeOnPath<Node>(path))
	)
	{
	}
}