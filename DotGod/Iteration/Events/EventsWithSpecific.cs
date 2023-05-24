using Tumbleweed.Events.Nullary;

namespace DotGod.Iteration.Events;

public sealed class EventsWithSpecific : IEvents
{
	public EventsWithSpecific(IEvent graphical, IEvent physical)
	{
		Graphical = graphical;
		Physical = physical;
	}
	
	public IEvent Graphical { get; }

	public IEvent Physical { get; }
}