using NullaryEvent = Tumbleweed.Event.Nullary;

namespace DotGod.Iteration.Event;

public interface Any
{
	NullaryEvent.Any Graphical { get; }
	
	NullaryEvent.Any Physical { get; }
}