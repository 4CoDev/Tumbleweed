using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Delegates.Events.Input;

public interface IInputEvents
{
	INullaryEvent Handled { get; }
	
	INullaryEvent Unhandled { get; }
}