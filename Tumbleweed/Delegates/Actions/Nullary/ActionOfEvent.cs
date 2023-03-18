using Tumbleweed.Delegates.Events.Nullary;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Delegates.Actions.Nullary;

public sealed class ActionOfEvent : ActionEnvelope
{
	public ActionOfEvent(INullaryEvent @event) : base
	(
		new ActionOfActions(
			new EnumerableOfFunction<INullaryAction>(
				() => @event.Listeners.Values))
	)
	{
	}
}