using Tumbleweed.Events;
using Tumbleweed.Events.Nullary;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Events.Iteration;

public interface IIterationEvents
{
	IEvent<IAction> Graphical { get; }
	
	IEvent<IAction> Physical { get; }
}