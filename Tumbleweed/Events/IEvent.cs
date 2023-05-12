namespace Tumbleweed.Events;

public interface IEvent<in T>
{
	void Unsubscribe(Object key);
	
	void Subscribe(Object key, T reaction);
}