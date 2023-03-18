using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Delegates.Events.Iteration;

public interface IIterationEvents
{
	INullaryEvent Graphical { get; }
	
	INullaryEvent Physical { get; }
}