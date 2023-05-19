using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary.Initiators;

public sealed class InitiatorWithValues : IInitiator
{
	public InitiatorWithValues
	(
		IEvent<IAction> @event,
		Action action
	) : this
	(
		@event,
		new ActionFromSystem(action)
	)
	{
	}
	
	public InitiatorWithValues
	(
		IEvent<IAction> @event,
		IAction invoke
	)
	{
		Event = @event;
		this.invoke = invoke;
	}
	
	public IEvent<IAction> Event { get; }

	public void Invoke() =>
		invoke.Invoke();
	
	private readonly IAction invoke;
}