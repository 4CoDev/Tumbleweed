using Godot;
using TumbleGD.Nodes.Existence.OfGodot;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Baking.Spatial.Spaces.Existence;

public sealed class RemovalOfSpace : ActionEnvelope
{
	public RemovalOfSpace(IScalar<Node> space) : base
	(
		new ActionFromSystem(
			() => Action(space))
	)
	{
	}

	private static void Action(IScalar<Node> space)
	{
		new RemovalOfNode(space).Invoke();
	}
}