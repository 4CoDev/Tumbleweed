using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Events.Nullary;

public sealed class EventOfScalar : INullaryEvent
{
	public EventOfScalar(IScalar<INullaryEvent> scalar) =>
		this.scalar = scalar;

	public IDictionary<Object, INullaryAction> Listeners =>
		scalar.Value.Listeners;

	private readonly IScalar<INullaryEvent> scalar;
}