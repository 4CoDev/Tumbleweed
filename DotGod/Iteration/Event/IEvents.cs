using Tumbleweed.Event.Nullary;

namespace DotGod.Iteration.Event;

public interface IEvents
{
	IEvent Graphical { get; }
	
	IEvent Physical { get; }
}