using Godot;
using TumbleGD.Nodes.FromFiles.OfGodot;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Existence.FromFiles.OfGodot;

public sealed class PlacementOfNode : ActionEnvelope
{
	public PlacementOfNode(Node parent, String path) : this
	(
		new ScalarOfValue<Node>(parent),
		new ScalarOfValue<String>(path)
	)
	{
	}
	
	public PlacementOfNode
	(
		IScalar<Node> parent,
		String path
	) : this
	(
		parent,
		new ScalarOfValue<String>(path)
	)
	{
	}

	public PlacementOfNode
	(
		IScalar<Node> parent,
		IScalar<String> path
	) : base
	(
		new Existence.OfGodot.PlacementOfNode(
			parent,
			new NodeOnPath(path))
	)
	{
	}
}