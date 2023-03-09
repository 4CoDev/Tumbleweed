using Godot;
using TumbleGD.Nodes.Existence.OfGodot;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical.Existence;

public sealed class PlacementOfSpace : ActionEnvelope
{
	public PlacementOfSpace
	(
		IScalar<Node> parent,
		IScalar<Node> space
	) : base
	(
		new ActionFromSystem(
			() => Action(parent, space))
	)
	{
	}

	private static void Action
	(
		IScalar<Node> parent,
		IScalar<Node> space
	)
	{
		new PlacementOfNode(parent, space).Invoke();
	}
}