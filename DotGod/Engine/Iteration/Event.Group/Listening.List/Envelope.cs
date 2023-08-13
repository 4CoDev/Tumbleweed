using List = Tumbleweed.Event.Listening.List;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.Listening.List;

public abstract class Envelope : Any
{
	protected Envelope(Any subscription) =>
		this.subscription = subscription;

	public List::Any<Procedure::Any> Graphical =>
		subscription.Graphical;

	public List::Any<Procedure::Any> Physical =>
		subscription.Physical;

	private readonly Any subscription;
}