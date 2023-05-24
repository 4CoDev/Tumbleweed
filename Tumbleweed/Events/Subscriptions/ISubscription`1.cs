namespace Tumbleweed.Events.Subscriptions;

public interface ISubscription<in T>
{
	void Unsubscribe(Object key);
	
	void Subscribe(Object key, T reaction);
}