using Tumbleweed.Delegates.Actions.Nullary;

namespace Tumbleweed.Delegates.Events.Nullary;

public interface INullaryEvent
{
	IDictionary<Object, INullaryAction> Listeners { get; }
}