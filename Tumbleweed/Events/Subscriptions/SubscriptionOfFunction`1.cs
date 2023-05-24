using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Events.Subscriptions;

public sealed class SubscriptionOfFunction<T> : SubscriptionEnvelope<T>
{
	public SubscriptionOfFunction(Func<ISubscription<T>> function) : this
	(
		new FunctionFromSystem<ISubscription<T>>(function)
	)
	{
	}
	
	public SubscriptionOfFunction
	(
		IFunction<ISubscription<T>> function
	) : base
	(
		new SubscriptionOfScalar<T>(
			new ResultOfFunction<ISubscription<T>>(function))
	)
	{
	}
}