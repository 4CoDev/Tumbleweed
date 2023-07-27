using Point = Tumbleweed.Point.Spatial;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Spatial.Function;

public sealed class Result<T> : Point::Envelope<T>
{
	public Result(System::Func<Point::Any<T>> function) : this
	(
		new Function::From.System<Point::Any<T>>(function)
	)
	{
	}
	
	public Result(Function::Any<Point::Any<T>> function) : base
	(
		new Point::Scalar.Value<T>(
			new Scalar::Function.Result<Point::Any<T>>(function))
	)
	{
	}
}