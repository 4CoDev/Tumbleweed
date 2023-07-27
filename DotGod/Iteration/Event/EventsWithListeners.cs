using Tumbleweed.Event.Nullary.With;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Iteration.Event;

public sealed class EventsWithListeners : Envelope
{
	public EventsWithListeners
	(
		IDictionary<Object, NullaryProcedure.Any> graphical,
		IDictionary<Object, NullaryProcedure.Any> physical
	) : base
	(
		new EventsWithSpecific(
			new Listeners(graphical),
			new Listeners(physical))
	)
	{
	}
}