using Tumbleweed.Event.Nullary;

namespace DotGod.Iteration.Event;

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