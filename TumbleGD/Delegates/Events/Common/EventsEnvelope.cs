using TumbleGD.Delegates.Events.Input;
using TumbleGD.Delegates.Events.Iteration;

namespace TumbleGD.Delegates.Events.Common;

public abstract class EventsEnvelope : ICommonEvents
{
	protected EventsEnvelope(ICommonEvents common) =>
		this.common = common;

	public IIterationEvents Iteration => common.Iteration;

	public IInputEvents Input => common.Input;

	private readonly ICommonEvents common;
}