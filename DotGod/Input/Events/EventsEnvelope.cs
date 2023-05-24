using Tumbleweed.Events.Nullary;

namespace DotGod.Input.Events;

public abstract class EventsEnvelope : IEvents
{
	protected EventsEnvelope(IEvents events) =>
		this.events = events;
	
	public IEvent Handled =>
		events.Handled;

	public IEvent Unhandled =>
		events.Unhandled;
	
	private readonly IEvents events;
}