using TumbleGD.Delegates.Events.Input;
using TumbleGD.Delegates.Events.Iteration;
using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Delegates.Events.Common;

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