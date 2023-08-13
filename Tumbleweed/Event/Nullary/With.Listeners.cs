using Event = Tumbleweed.Event;
using SCG = System.Collections.Generic;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using System = System;
using List = Tumbleweed.Event.Listening.List;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Nullary.With;

public sealed class Listeners : Event::Envelope<Procedure::Any>
{
	public Listeners
	(
		SCG::IDictionary<System::Object, Procedure::Any> listeners
	) : base
	(
		new Event::Nullary.With.Members(
			new List::With.Dictionary<Procedure::Any>(listeners),
			new Event::Nullary.Reaction.Of.Listeners(listeners))
	)
	{
	}
}