using Tumbleweed.Events.Subscriptions;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Iteration.Events.Subscriptions;

public abstract class SubscriptionsEnvelope : ISubscriptions
{
	protected SubscriptionsEnvelope(ISubscriptions pool) =>
		this.pool = pool;

	public ISubscription<IAction> Graphical =>
		pool.Graphical;

	public ISubscription<IAction> Physical =>
		pool.Physical;

	private readonly ISubscriptions pool;
}