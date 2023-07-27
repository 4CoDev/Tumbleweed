using NullaryEvent = Tumbleweed.Event.Nullary;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;
using System = System;

namespace Tumbleweed.Event.Nullary;

public sealed class Empty : NullaryEvent.Envelope
{
	public Empty() : base
	(
		new NullaryEvent.With.Listeners(
			new Dictionary<System::Object, NullaryProcedure.Any>())
	)
	{
	}
}