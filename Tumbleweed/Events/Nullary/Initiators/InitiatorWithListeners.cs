using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary.Initiators;

public sealed class InitiatorWithListeners : InitiatorEnvelope
{
	public InitiatorWithListeners
	(
		IDictionary<Object, IAction> listeners
	) : base
	(
		new InitiatorWithValues(
			@event: new EventWithListeners<IAction>(listeners),
			invoke: new ReactionOfListeners(listeners))
	)
	{
	}
}