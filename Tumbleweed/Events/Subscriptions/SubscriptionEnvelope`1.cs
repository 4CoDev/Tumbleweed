namespace Tumbleweed.Events.Subscriptions;

public abstract class SubscriptionEnvelope<T> : ISubscription<T>
{
	protected SubscriptionEnvelope(ISubscription<T> subscription) =>
		this.subscription = subscription;

	public override Boolean Equals(Object? @object) =>
		subscription.Equals(@object);

	public override Int32 GetHashCode() =>
		subscription.GetHashCode();

	public override String? ToString() =>
		subscription.ToString();

	public void Unsubscribe(Object key) =>
		subscription.Unsubscribe(key);

	public void Subscribe(Object key, T reaction) =>
		subscription.Subscribe(key, reaction);

	private readonly ISubscription<T> subscription;
}