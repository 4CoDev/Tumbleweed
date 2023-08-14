using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group;

public abstract class Envelope : Any
{
	protected Envelope(Any group) =>
		this.group = group;
	
	public Event::Any<Procedure::Any> Graphical =>
		group.Graphical;

	public Event::Any<Procedure::Any> Physical =>
		group.Physical;
	
	private readonly Any group;
}