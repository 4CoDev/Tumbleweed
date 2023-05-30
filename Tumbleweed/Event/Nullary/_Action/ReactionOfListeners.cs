using Tumbleweed.Dictionary;
using Tumbleweed.Subroutine.Nullary.Action;

namespace Tumbleweed.Event.Nullary._Action;

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