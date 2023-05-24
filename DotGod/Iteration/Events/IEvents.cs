using Tumbleweed.Events.Nullary;

namespace DotGod.Iteration.Events;

public interface IEvents
{
	IEvent Graphical { get; }
	
	IEvent Physical { get; }
}