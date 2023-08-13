using Tumbleweed.Event.Listening.List;

namespace DotGod.Engine.Input.Event.Group.Listening.List;

public abstract class Envelope : Any
{
	protected Envelope(Any events) =>
		this.events = events;

	public Any<Tumbleweed.Subroutine.Procedure.Nullary.Any> Handled => events.Handled;

	public Any<Tumbleweed.Subroutine.Procedure.Nullary.Any> Unhandled => events.Unhandled;

	private readonly Any events;
}