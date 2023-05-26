using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Action.Nullary;

namespace DotGod.Iteration.Event.Subscription;

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