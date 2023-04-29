using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Input;

public sealed class EmptyEvents : EventsEnvelope
{
	public EmptyEvents() : base
	(
		new EventsWithValues(
			new EmptyEvent(),
			new EmptyEvent())
	)
	{
	}
}