using Event = Tumbleweed.Event;

namespace Tumbleweed.Event;

public abstract class Envelope<T> : Event::Any<T>
{
	protected Envelope(Event::Any<T> @event) =>
		this.@event = @event;

	public Listening.List.Any<T> Listeners =>
		@event.Listeners;

	public void Invoke() =>
		@event.Invoke();

	private readonly Event::Any<T> @event;
}