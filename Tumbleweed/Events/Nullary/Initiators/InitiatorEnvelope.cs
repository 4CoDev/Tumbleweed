using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary.Initiators;

public abstract class InitiatorEnvelope : IInitiator
{
	protected InitiatorEnvelope(IInitiator initiator) =>
		this.initiator = initiator;

	public IEvent<IAction> Event =>
		initiator.Event;

	public void Invoke() =>
		initiator.Invoke();
	
	private readonly IInitiator initiator;
}