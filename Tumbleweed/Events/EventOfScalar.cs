using Tumbleweed.Scalars;

namespace Tumbleweed.Events;

public sealed class EventOfScalar<T> : IEvent<T>
{
	public EventOfScalar(IScalar<IEvent<T>> scalar) =>
		this.scalar = scalar;

	public void Unsubscribe(Object key) =>
		scalar.Value.Unsubscribe(key);

	public void Subscribe(Object key, T reaction) =>
		scalar.Value.Subscribe(key, reaction);

	private readonly IScalar<IEvent<T>> scalar;
}