using Tumbleweed.Delegates.Actions.Nullary;

namespace Tumbleweed.Delegates.Events.Nullary;

public sealed class EmptyEvent : EventEnvelope
{
	public EmptyEvent() : base
	(
		new EventWithListeners(
			new Dictionary<Object, INullaryAction>())
	)
	{
	}
}