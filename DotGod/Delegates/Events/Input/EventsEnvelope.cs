using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Input;

public abstract class EventsEnvelope : IInputEvents
{
	protected EventsEnvelope(IInputEvents events) =>
		this.events = events;

	public INullaryEvent Handled => events.Handled;

	public INullaryEvent Unhandled => events.Unhandled;

	private readonly IInputEvents events;
}