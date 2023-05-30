using Tumbleweed.Subroutine.Nullary.Action;

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