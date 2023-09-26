using Tumbleweed.Mathematics.Geometry.Planimetry.Point.Scalar.Value;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Point = Tumbleweed.Point.Planar;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Mathematics.Geometry.Planimetry.Point.Function.Result;

public sealed class Actual<T> : Envelope<T>
{
	public Actual
	(
		System::Func<Any<T>> function
	) : this
	(
		new Function::From.System<Any<T>>(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<Any<T>> function
	) : base
	(
		new Scalar.Value.Actual<T>(
			new Scalar::Function.Result.Actual<Any<T>>(function))
	)
	{
	}
}