using Tumbleweed.Subroutine.Action.Nullary;

namespace Tumbleweed.Event.Nullary;

public sealed class EventWithoutListeners : EventEnvelope
{
	public EventWithoutListeners() : base
	(
		new EventWithListeners(
			new Dictionary<Object, IAction>())
	)
	{
	}
}