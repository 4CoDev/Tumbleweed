using Event = Tumbleweed.Event.Nullary;
using SCG = System.Collections.Generic;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using System = System;
using List = Tumbleweed.Event.Listening.List;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Nullary.With;

public sealed class Listeners : Event::Envelope
{
	public Listeners
	(
		SCG::IDictionary<System::Object, Procedure::Any> listeners
	) : base
	(
		new Event::With.Members(
			new List::With.Dictionary<Procedure::Any>(listeners),
			new Event::Reaction.Of.Listeners(listeners))
	)
	{
	}
}