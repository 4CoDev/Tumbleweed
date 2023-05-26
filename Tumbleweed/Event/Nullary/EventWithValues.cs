using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Action.Nullary;

namespace Tumbleweed.Event.Nullary;

public sealed class EventWithValues : IEvent
{
	public EventWithValues
	(
		ISubscription<IAction> subscription,
		Action invoke
	) : this
	(
		subscription,
		new ActionFromSystem(invoke)
	)
	{
	}
	
	public EventWithValues
	(
		ISubscription<IAction> subscription,
		IAction invoke
	)
	{
		Subscription = subscription;
		this.invoke = invoke;
	}
	
	public ISubscription<IAction> Subscription { get; }

	public void Invoke() =>
		invoke.Invoke();
	
	private readonly IAction invoke;
}