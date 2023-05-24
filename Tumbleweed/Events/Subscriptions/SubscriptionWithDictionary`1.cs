namespace Tumbleweed.Events.Subscriptions;

public sealed class SubscriptionWithDictionary<T> : ISubscription<T>
{
	public SubscriptionWithDictionary(IDictionary<Object, T> dictionary) =>
		this.dictionary = dictionary;
	
	public void Unsubscribe(Object key) =>
		dictionary.Remove(key);

	public void Subscribe(Object key, T reaction) =>
		dictionary.Add(key, reaction);

	private readonly IDictionary<Object, T> dictionary;
}