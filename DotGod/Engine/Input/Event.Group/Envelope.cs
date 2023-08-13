using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Input.Event.Group;

public abstract class Envelope : Any
{
	protected Envelope(Any events) =>
		this.events = events;
	
	public Event::Any<Procedure::Any> Handled =>
		events.Handled;

	public Event::Any<Procedure::Any> Unhandled =>
		events.Unhandled;
	
	private readonly Any events;
}