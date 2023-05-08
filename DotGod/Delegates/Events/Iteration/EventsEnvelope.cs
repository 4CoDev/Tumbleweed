using Tumbleweed.Delegates.Events.Nullary;

namespace DotGod.Delegates.Events.Iteration;

public abstract class EventsEnvelope : IIterationEvents
{
	protected EventsEnvelope(IIterationEvents pool) =>
		this.pool = pool;

	public IEvent Graphical =>
		pool.Graphical;

	public IEvent Physical =>
		pool.Physical;

	private readonly IIterationEvents pool;
}