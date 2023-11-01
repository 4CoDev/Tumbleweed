using List = Tumbleweed.Event.Listening.List;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Listening.List.Function;

public sealed class Result<T> : List::Envelope<T>
{
	public Result
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
	
	public Result
	(
		Function::Any<List::Any<T>> function
	) : base
	(
		new List::Scalar.Value<T>(
			new Property::Function.Result.Actual
				<List::Any<T>>
				(function))
	)
	{
	}
}