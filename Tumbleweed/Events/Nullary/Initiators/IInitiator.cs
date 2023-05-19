using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary.Initiators;

public interface IInitiator
{
	IEvent<IAction> Event { get; }
	
	void Invoke();
}