using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Spatial.Function;

public sealed class Result<T> : Envelope<T>
{
	public Result(System::Func<Any<T>> function) : this
	(
		new Function::From.System<Any<T>>(function)
	)
	{
	}
	
	public Result(Function::Any<Any<T>> function) : base
	(
		new Point::Scalar.Value<T>(
			new Actual<Any<T>>(function))
	)
	{
	}
}