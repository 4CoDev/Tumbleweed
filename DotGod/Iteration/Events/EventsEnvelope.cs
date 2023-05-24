using Tumbleweed.Events.Nullary;

namespace DotGod.Iteration.Events;

public abstract class EventsEnvelope : IEvents
{
	protected EventsEnvelope(IEvents events) =>
		this.events = events;
	
	public IEvent Graphical =>
		events.Graphical;

	public IEvent Physical =>
		events.Physical;
	
	private readonly IEvents events;
}