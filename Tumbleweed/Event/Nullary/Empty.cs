using Nullary = Tumbleweed.Event.Nullary;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using SCG = System.Collections.Generic;
using System = System;

namespace Tumbleweed.Event.Nullary;

public sealed class Empty : Nullary::Envelope
{
	public Empty() : base
	(
		new Nullary::With.Listeners(
			new SCG::Dictionary<System::Object, Procedure::Any>())
	)
	{
	}
}