using Event = Tumbleweed.Event;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Event.Nullary.Function.Result;

public sealed class Actual : Event::Envelope<Procedure::Any>
{
	public Actual
	(
		System::Func<Event::Any<Procedure::Any>> function
	) : this
	(
		new Function::From.System
			<Event::Any<Procedure::Any>>
			(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<Event::Any<Procedure::Any>> function
	) : base
	(
		new Event::Function.Result.Actual
			<Procedure::Any>
			(function)
	)
	{
	}
}