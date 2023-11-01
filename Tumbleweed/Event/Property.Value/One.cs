using Event = Tumbleweed.Event;
using Property = Tumbleweed.Property.Output;
using List = Tumbleweed.Event.Listening.List;

namespace Tumbleweed.Event.Property.Value;

public sealed class One<T> : Event::Any<T>
{
	public One(Property::Any<Event::Any<T>> property) =>
		this.property = property;

	public List::Any<T> Listeners =>
		property.Value.Listeners;

	public void Invoke() =>
		property.Value.Invoke();
	
	private readonly Property::Any<Event::Any<T>> property;
}