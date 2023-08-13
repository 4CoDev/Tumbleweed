using Event = Tumbleweed.Event;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Scalar = Tumbleweed.Scalar.Immutable;

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
		new Event::Scalar.Value.One<T>(
			new Scalar::Function.Result.Actual
				<Event::Any<T>>
				(function))
	)
	{
	}
}