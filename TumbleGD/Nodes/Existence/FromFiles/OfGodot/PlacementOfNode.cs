using Godot;
using TumbleGD.Nodes.FromFiles.OfGodot;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Existence.FromFiles.OfGodot;

public sealed class PlacementOfNode : ActionEnvelope
{
	public PlacementOfNode(Node parent, string path) : this
	(
		new ScalarOfValue<Node>(parent),
		new ScalarOfValue<string>(path)
	)
	{
	}
	
	public PlacementOfNode
	(
		IScalar<Node> parent,
		string path
	) : this
	(
		parent,
		new ScalarOfValue<string>(path)
	)
	{
	}

	public PlacementOfNode
	(
		IScalar<Node> parent,
		IScalar<string> path
	) : base
	(
		new Existence.OfGodot.PlacementOfNode(
			parent,
			new NodeOnPath(path))
	)
	{
	}
}