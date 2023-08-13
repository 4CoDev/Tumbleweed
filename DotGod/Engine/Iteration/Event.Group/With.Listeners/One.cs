using SCG = System.Collections.Generic;
using System = System;
using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.With.Listeners;

public sealed class One : Envelope
{
	public One
	(
		SCG::IDictionary<System::Object, Procedure::Any> graphical,
		SCG::IDictionary<System::Object, Procedure::Any> physical
	) : base
	(
		new Events.One(
			new Event::Nullary.With.Listeners(graphical),
			new Event::Nullary.With.Listeners(physical))
	)
	{
	}
}