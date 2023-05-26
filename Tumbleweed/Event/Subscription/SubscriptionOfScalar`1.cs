using Tumbleweed.Scalar;

namespace Tumbleweed.Event.Subscription;

public sealed class SubscriptionOfScalar<T> : ISubscription<T>
{
	public SubscriptionOfScalar(IScalar<ISubscription<T>> scalar) =>
		this.scalar = scalar;

	public void Unsubscribe(Object key) =>
		scalar.Value.Unsubscribe(key);

	public void Subscribe(Object key, T reaction) =>
		scalar.Value.Subscribe(key, reaction);

	private readonly IScalar<ISubscription<T>> scalar;
}