using Option = Tumbleweed.Property.Option;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;
using Boolean = Tumbleweed.Mathematics.Boolean;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Option.Function;

public sealed class Actual<T> : Option::Any<T>
{
	public Actual
	(
		System::Func<Option::Any<T>> function
	) : this
	(
		new Function::From.System
			<Option::Any<T>>
			(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<Option::Any<T>> function
	)
	{
		this.function = function;
	}

	public T Value =>
		function.Result.Value;

	public Boolean::Any HasValue =>
		function.Result.HasValue;

	private readonly Function::Any<Option::Any<T>> function;
}