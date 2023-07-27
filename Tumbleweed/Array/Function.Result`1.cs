using Array = Tumbleweed.Array;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Function = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Function;

public sealed class Result<T> : Array::Envelope<T>
{
	public Result
	(
		System::Func<Array::Any<T>> function
	) : this
	(
		new Function::From.System<Array::Any<T>>(function)
	)
	{
	}
	
	public Result
	(
		Function::Any<Array::Any<T>> function
	) : base
	(
		new Array::Scalar.Value<T>(
			new Scalar::Function.Result<Array::Any<T>>(function))
	)
	{
	}
}