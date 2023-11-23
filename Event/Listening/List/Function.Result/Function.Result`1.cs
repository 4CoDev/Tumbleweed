using List = Tumbleweed.Event.Listening.List;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Event.Listening.List.Function.Result;

public sealed class Actual<T> : List::Any<T>
{
	public Actual
	(
		System::Func<List::Any<T>> function
	) : this
	(
		new Function::From.System
			<List::Any<T>>
			(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<List::Any<T>> function
	)
	{
		this.function = function;
	}

	public void Unsubscribe(System::Object key) =>
		function.Result.Unsubscribe(key);

	public void Subscribe(System::Object key, T reaction) =>
		function.Result.Subscribe(key, reaction);

	private readonly Function::Any<List::Any<T>> function;
}