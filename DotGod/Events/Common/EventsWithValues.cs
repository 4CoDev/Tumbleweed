using DotGod.Events.Input;
using DotGod.Events.Iteration;

namespace DotGod.Events.Common;

public sealed class EventsWithValues : ICommonEvents
{
	public EventsWithValues
	(
		IIterationEvents iteration,
		IInputEvents input
	)
	{
		Iteration = iteration;
		Input = input;
	}


	public IIterationEvents Iteration { get; }

	public IInputEvents Input { get; }
}