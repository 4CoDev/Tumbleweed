using Event = Tumbleweed.Event;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Event.Function.Result;

public sealed class Actual<T> : Event::Envelope<T>
{
	public Actual
	(
		System::Func<Event::Any<T>> function
	) : this
	(
		new Function::From.System<Any<T>>(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<Event::Any<T>> function
	) : base
	(
		new Event::Property.Value.One<T>(
			new Property::Function.Result.Actual
				<Event::Any<T>>
				(function))
	)
	{
	}
}