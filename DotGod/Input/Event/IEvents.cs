using Tumbleweed.Event.Nullary;

namespace DotGod.Input.Event;

public interface IEvents
{
	Any Handled { get; }
	
	Any Unhandled { get; }
}