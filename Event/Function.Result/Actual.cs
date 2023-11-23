using Event = Tumbleweed.Event;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using List = Tumbleweed.Event.Listening.List;

namespace Tumbleweed.Event.Function.Result;

public sealed class Actual<T> : Event::Any<T>
{
	public Actual
	(
		Func<Event::Any<T>> function
	) : this
	(
		new Function::From.System
			<Event::Any<T>>
			(function)
	)
	{
	}

	public Actual
	(
		Function::Any<Event::Any<T>> function
	)
	{
		this.function = function;
	}

	public List::Any<T> Listeners =>
		function.Result.Listeners;

	public void Invoke() =>
		function.Result.Invoke();

	private readonly Function::Any<Event::Any<T>> function;
}