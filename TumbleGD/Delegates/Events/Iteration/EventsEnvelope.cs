using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Delegates.Events.Iteration;

public abstract class EventsEnvelope : IIterationEvents
{
	protected EventsEnvelope(IIterationEvents pool) =>
		this.pool = pool;

	public INullaryEvent Graphical =>
		pool.Graphical;

	public INullaryEvent Physical =>
		pool.Physical;

	private readonly IIterationEvents pool;
}