using Tumbleweed.Events;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Events.Iteration;

public sealed class EventsWithValues : IIterationEvents
{
	public EventsWithValues
	(
		IEvent<IAction> graphical,
		IEvent<IAction> physical
	)
	{
		Graphical = graphical;
		Physical = physical;
	}
	
	public IEvent<IAction> Graphical { get; }

	public IEvent<IAction> Physical { get; }
}