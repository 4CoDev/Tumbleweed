using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Iteration;

public interface IIterationEvents
{
	IEvent Graphical { get; }
	
	IEvent Physical { get; }
}