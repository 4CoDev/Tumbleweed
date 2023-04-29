using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Input;

public interface IInputEvents
{
	INullaryEvent Handled { get; }
	
	INullaryEvent Unhandled { get; }
}