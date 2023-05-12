namespace Tumbleweed.Events;

public sealed class EventWithListeners<T> : IEvent<T>
{
	public EventWithListeners(IDictionary<Object, T> listeners) =>
		this.listeners = listeners;
	
	public void Unsubscribe(Object key) =>
		listeners.Remove(key);

	public void Subscribe(Object key, T reaction) =>
		listeners.Add(key, reaction);

	private readonly IDictionary<Object, T> listeners;
}