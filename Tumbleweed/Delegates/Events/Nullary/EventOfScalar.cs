using Tumbleweed.Delegates.Actions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Events.Nullary;

public sealed class EventOfScalar : IEvent
{
	public EventOfScalar(IScalar<IEvent> scalar) =>
		this.scalar = scalar;

	public IDictionary<Object, IAction> Listeners =>
		scalar.Value.Listeners;

	private readonly IScalar<IEvent> scalar;
}