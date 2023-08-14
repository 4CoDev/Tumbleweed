using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Input.Event.Group;

public abstract class Envelope : Any
{
	protected Envelope(Any group) =>
		this.group = group;
	
	public Event::Any<Procedure::Any> Handled =>
		group.Handled;

	public Event::Any<Procedure::Any> Unhandled =>
		group.Unhandled;
	
	private readonly Any group;
}