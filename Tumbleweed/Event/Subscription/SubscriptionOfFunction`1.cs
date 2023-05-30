using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace Tumbleweed.Event.Subscription;

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