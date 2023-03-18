using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Delegates.Events.Iteration;

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