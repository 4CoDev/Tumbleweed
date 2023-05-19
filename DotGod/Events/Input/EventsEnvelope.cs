using Tumbleweed.Events;
using Tumbleweed.Events.Nullary;
using Tumbleweed.Subroutines.Actions.Nullary;

namespace DotGod.Events.Input;

public abstract class EventsEnvelope : IInputEvents
{
	protected EventsEnvelope(IInputEvents events) =>
		this.events = events;

	public IEvent<IAction> Handled => events.Handled;

	public IEvent<IAction> Unhandled => events.Unhandled;

	private readonly IInputEvents events;
}