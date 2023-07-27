using System = System;

namespace Tumbleweed.Event.Subscription;

public interface Any<in T>
{
	void Unsubscribe(System::Object key);
	
	void Subscribe(System::Object key, T reaction);
}