using DotGod.Delegates.Events.Input;
using DotGod.Delegates.Events.Iteration;
using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Common;

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