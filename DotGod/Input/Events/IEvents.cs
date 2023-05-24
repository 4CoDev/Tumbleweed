using Tumbleweed.Events.Nullary;

namespace DotGod.Input.Events;

public interface IEvents
{
	IEvent Handled { get; }
	
	IEvent Unhandled { get; }
}