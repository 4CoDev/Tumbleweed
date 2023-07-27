using Tumbleweed.Event.Nullary;

namespace DotGod.Input.Event;

public abstract class EventsEnvelope : IEvents
{
	protected EventsEnvelope(IEvents events) =>
		this.events = events;
	
	public Any Handled =>
		events.Handled;

	public Any Unhandled =>
		events.Unhandled;
	
	private readonly IEvents events;
}