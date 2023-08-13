using Event = Tumbleweed.Event;
using Scalar = Tumbleweed.Scalar.Immutable;
using List = Tumbleweed.Event.Listening.List;

namespace Tumbleweed.Event.Scalar.Value;

public sealed class One<T> : Event::Any<T>
{
	public One(Scalar::Any<Event::Any<T>> scalar) =>
		this.scalar = scalar;

	public List::Any<T> Listeners =>
		scalar.Value.Listeners;

	public void Invoke() =>
		scalar.Value.Invoke();
	
	private readonly Scalar::Any<Event::Any<T>> scalar;
}