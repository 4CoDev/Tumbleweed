using NullaryEvent = Tumbleweed.Event.Nullary;

namespace DotGod.Iteration.Event;

public abstract class Envelope : Any
{
	protected Envelope(Any events) =>
		this.events = events;
	
	public NullaryEvent.Any Graphical =>
		events.Graphical;

	public NullaryEvent.Any Physical =>
		events.Physical;
	
	private readonly Any events;
}