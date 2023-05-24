using Tumbleweed.Dictionaries;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace Tumbleweed.Events.Nullary.Actions;

public sealed class ReactionOfListeners : ActionEnvelope
{
	public ReactionOfListeners
	(
		IDictionary<Object, IAction> listeners
	) : base
	(
		new ActionOfActions(
			new ValuesOfDictionary<IAction>(listeners))
	)
	{
	}
}