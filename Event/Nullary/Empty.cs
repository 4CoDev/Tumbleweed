using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using SCG = System.Collections.Generic;
using System = System;

namespace Tumbleweed.Event.Nullary;

public sealed class Empty : Event::Envelope<Procedure::Any>
{
	public Empty() : base
	(
		new Event::Nullary.With.Listeners(
			new SCG::Dictionary<System::Object, Procedure::Any>())
	)
	{
	}
}