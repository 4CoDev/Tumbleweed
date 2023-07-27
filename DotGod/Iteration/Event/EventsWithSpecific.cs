using Tumbleweed.Event.Nullary;

namespace DotGod.Iteration.Event;

public sealed class EventsWithSpecific : Any
{
	public EventsWithSpecific(Tumbleweed.Event.Nullary.Any graphical, Tumbleweed.Event.Nullary.Any physical)
	{
		Graphical = graphical;
		Physical = physical;
	}
	
	public Tumbleweed.Event.Nullary.Any Graphical { get; }

	public Tumbleweed.Event.Nullary.Any Physical { get; }
}