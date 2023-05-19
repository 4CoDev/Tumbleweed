using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Events;

public sealed class EventOfFunction<T> : EventEnvelope<T>
{
	public EventOfFunction(Func<IEvent<T>> function) : this
	(
		new FunctionFromSystem<IEvent<T>>(function)
	)
	{
	}
	
	public EventOfFunction
	(
		IFunction<IEvent<T>> function
	) : base
	(
		new EventOfScalar<T>(
			new ResultOfFunction<IEvent<T>>(function))
	)
	{
	}
}