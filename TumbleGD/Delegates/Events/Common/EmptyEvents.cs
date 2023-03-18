namespace TumbleGD.Delegates.Events.Common;

public sealed class EmptyEvents : EventsEnvelope
{
	public EmptyEvents() : base
	(
		new EventsWithValues(
			new Iteration.EmptyEvents(),
			new Input.EmptyEvents())
	)
	{
	}
}