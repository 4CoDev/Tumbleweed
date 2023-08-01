using List = Tumbleweed.Event.Listening.List;
using Event = Tumbleweed.Event.Nullary;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Event.Nullary;

public abstract class Envelope : Event::Any
{
	protected Envelope(Event::Any @event) =>
		this.@event = @event;

	public List::Any<Procedure::Any> Listeners =>
		@event.Listeners;

	public void Invoke() =>
		@event.Invoke();

	private readonly Event::Any @event;
}