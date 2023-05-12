using Tumbleweed.Events;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Events.Input;

public interface IInputEvents
{
	IEvent<IAction> Handled { get; }
	
	IEvent<IAction> Unhandled { get; }
}