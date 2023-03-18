using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Events.Nullary;

public sealed class EventOfFunction : EventEnvelope
{
	public EventOfFunction(Func<INullaryEvent> function) : this
	(
		new NullaryFromSystem<INullaryEvent>(function)
	)
	{
	}
	
	public EventOfFunction
	(
		INullaryFunction<INullaryEvent> function
	) : base
	(
		new EventOfScalar(
			new ValueOfFunction<INullaryEvent>(function))
	)
	{
	}
}