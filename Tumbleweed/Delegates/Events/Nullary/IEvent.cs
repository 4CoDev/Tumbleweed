using Tumbleweed.Delegates.Actions.Nullary;

namespace Tumbleweed.Delegates.Events.Nullary;

public interface IEvent
{
	IDictionary<Object, IAction> Listeners { get; }
}