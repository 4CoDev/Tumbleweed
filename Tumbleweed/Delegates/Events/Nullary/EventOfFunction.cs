using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Events.Nullary;

public sealed class EventOfFunction : EventEnvelope
{
	public EventOfFunction(Func<IEvent> function) : this
	(
		new FunctionFromSystem<IEvent>(function)
	)
	{
	}
	
	public EventOfFunction
	(
		IFunction<IEvent> function
	) : base
	(
		new EventOfScalar(
			new ResultOfFunction<IEvent>(function))
	)
	{
	}
}