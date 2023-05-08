using Tumbleweed.Delegates.Events.Nullary;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Delegates.Actions.Nullary;

public sealed class ActionOfEvent : ActionEnvelope
{
	public ActionOfEvent(IEvent @event) : base
	(
		new ActionOfActions(
			new EnumerableOfFunction<IAction>(
				() => @event.Listeners.Values))
	)
	{
	}
}