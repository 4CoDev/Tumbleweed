using Godot;
using TumbleGD.Nodes.FromFiles.OfGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement.FromFiles.OfGodot;

public sealed class NodeOnPath : PlacementEnvelope
{
	public NodeOnPath(Node relation, string path) : this
	(
		new ScalarOfValue<Node>(relation),
		new ScalarOfValue<string>(path)
	)
	{
	}

	public NodeOnPath
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