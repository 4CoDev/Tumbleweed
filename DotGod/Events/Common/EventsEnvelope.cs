using DotGod.Events.Input;
using DotGod.Events.Iteration;

namespace DotGod.Events.Common;

public abstract class EventsEnvelope : ICommonEvents
{
	protected EventsEnvelope(ICommonEvents common) =>
		this.common = common;

	public IIterationEvents Iteration => common.Iteration;

	public IInputEvents Input => common.Input;

	private readonly ICommonEvents common;
}