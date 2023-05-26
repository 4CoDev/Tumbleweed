using Tumbleweed.Event.Nullary;

namespace DotGod.Input.Event;

public interface IEvents
{
	IEvent Handled { get; }
	
	IEvent Unhandled { get; }
}