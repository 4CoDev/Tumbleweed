using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary;

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