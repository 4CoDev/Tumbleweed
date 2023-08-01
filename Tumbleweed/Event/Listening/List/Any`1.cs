using System = System;

namespace Tumbleweed.Event.Listening.List;

public interface Any<in T>
{
	void Unsubscribe(System::Object key);
	
	void Subscribe(System::Object key, T reaction);
}