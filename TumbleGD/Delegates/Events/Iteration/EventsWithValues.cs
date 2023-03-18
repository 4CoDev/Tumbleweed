using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Delegates.Events.Iteration;

public sealed class EventsWithValues : IIterationEvents
{
	public EventsWithValues
	(
		INullaryEvent graphicals,
		INullaryEvent physicals
	)
	{
		Graphical = graphicals;
		Physical = physicals;
	}
	
	public INullaryEvent Graphical { get; }

	public INullaryEvent Physical { get; }
}