using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Input;

public interface IInputEvents
{
	IEvent Handled { get; }
	
	IEvent Unhandled { get; }
}