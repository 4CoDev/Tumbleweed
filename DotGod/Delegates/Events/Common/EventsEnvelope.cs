using DotGod.Delegates.Events.Input;
using DotGod.Delegates.Events.Iteration;

namespace DotGod.Delegates.Events.Common;

public abstract class EventsEnvelope : ICommonEvents
{
	protected EventsEnvelope(ICommonEvents common) =>
		this.common = common;

	public IIterationEvents Iteration => common.Iteration;

	public IInputEvents Input => common.Input;

	private readonly ICommonEvents common;
}