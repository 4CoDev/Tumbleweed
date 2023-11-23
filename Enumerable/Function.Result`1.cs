using Tumbleweed.Property.Output.Function.Result;
using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Function;

public sealed class Result<T> : Enumerable::Envelope<T>
{
	public Result
	(
		System::Func<IEnumerable<T>> function
	) : this
	(
		new Function::From.System<IEnumerable<T>>(function)
	)
	{
	}
	
	public Result
	(
		Function::Any<IEnumerable<T>> function
	) : base
	(
		new Enumerable::Property.Value<T>(
			new Actual<IEnumerable<T>>(function))
	)
	{
	}
}