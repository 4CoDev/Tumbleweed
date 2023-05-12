using Tumbleweed.Events;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Events.Iteration;

public abstract class EventsEnvelope : IIterationEvents
{
	protected EventsEnvelope(IIterationEvents pool) =>
		this.pool = pool;

	public IEvent<IAction> Graphical =>
		pool.Graphical;

	public IEvent<IAction> Physical =>
		pool.Physical;

	private readonly IIterationEvents pool;
}