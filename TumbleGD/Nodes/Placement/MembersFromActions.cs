using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Placement;

public sealed class MembersFromActions : INodePlacement
{
	public MembersFromActions(Action place, Action remove) : this
	(
		new ActionFromSystem(place),
		new ActionFromSystem(remove)
	)
	{
	}

	public MembersFromActions(INullaryAction place, INullaryAction remove)
	{
		this.place = place;
		this.remove = remove;
	}

	public void Place() => place.Invoke();

	public void Remove() => remove.Invoke();

	private readonly INullaryAction place;
	
	private readonly INullaryAction remove;
}