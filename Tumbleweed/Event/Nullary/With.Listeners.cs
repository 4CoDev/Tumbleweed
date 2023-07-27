using NullaryEvent = Tumbleweed.Event.Nullary;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Nullary.With;

public sealed class Listeners : NullaryEvent.Envelope
{
	public Listeners
	(
		IDictionary<System::Object, NullaryProcedure.Any> listeners
	) : base
	(
		new Members(
			new Subscription.With.Dictionary<NullaryProcedure.Any>(listeners),
			new Reaction.Of.Listeners(listeners))
	)
	{
	}
}