using Godot;
using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Delegates.Actions.Unary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement;

public sealed class PlacementWithMembers : INodePlacement
{
	public PlacementWithMembers
	(
		Action<IScalar<Node>> place,
		Action remove
	) : this
	(
		new ActionFromSystem<IScalar<Node>>(place),
		new ActionFromSystem(remove)
	)
	{
	}
	
	public PlacementWithMembers
	(
		IUnaryAction<IScalar<Node>> place,
		INullaryAction remove
	)
	{
		this.place = place;
		this.remove = remove;
	}

	public void Place(IScalar<Node> parent) =>
		place.Invoke(parent);

	public void Remove() =>
		remove.Invoke();

	private readonly IUnaryAction<IScalar<Node>> place;
	
	private readonly INullaryAction remove;
}