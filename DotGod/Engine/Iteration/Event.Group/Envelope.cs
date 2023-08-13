using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group;

public abstract class Envelope : Any
{
	protected Envelope(Any events) =>
		this.events = events;
	
	public Event::Any<Procedure::Any> Graphical =>
		events.Graphical;

	public Event::Any<Procedure::Any> Physical =>
		events.Physical;
	
	private readonly Any events;
}