using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Iteration;

public sealed class EventsWithValues : IIterationEvents
{
	public EventsWithValues
	(
		IEvent graphicals,
		IEvent physicals
	)
	{
		Graphical = graphicals;
		Physical = physicals;
	}
	
	public IEvent Graphical { get; }

	public IEvent Physical { get; }
}