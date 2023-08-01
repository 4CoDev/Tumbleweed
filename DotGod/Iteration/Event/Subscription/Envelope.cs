using Tumbleweed.Event.Listening.List;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Iteration.Event.Subscription;

public abstract class SubscriptionsEnvelope : Subscription.Any
{
	protected SubscriptionsEnvelope(Subscription.Any subscription) =>
		this.subscription = subscription;

	public Any<NullaryProcedure.Any> Graphical =>
		subscription.Graphical;

	public Any<NullaryProcedure.Any> Physical =>
		subscription.Physical;

	private readonly Subscription.Any subscription;
}