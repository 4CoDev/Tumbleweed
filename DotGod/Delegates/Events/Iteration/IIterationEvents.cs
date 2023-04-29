using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Iteration;

public interface IIterationEvents
{
	INullaryEvent Graphical { get; }
	
	INullaryEvent Physical { get; }
}