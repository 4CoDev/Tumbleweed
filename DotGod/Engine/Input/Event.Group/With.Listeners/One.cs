namespace DotGod.Engine.Input.Event.Group.With.Listeners;

public sealed class One : Envelope
{
	public One
	(
		IDictionary<Object, Tumbleweed.Subroutine.Procedure.Nullary.Any> handled,
		IDictionary<Object, Tumbleweed.Subroutine.Procedure.Nullary.Any> unhandled
	) : base
	(
		new Events.One(
			new Tumbleweed.Event.Nullary.With.Listeners(handled),
			new Tumbleweed.Event.Nullary.With.Listeners(unhandled))
	)
	{
	}
}