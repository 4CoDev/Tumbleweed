using Tumbleweed.Array.Dimension.Multi.Scalar.Value.Actual;
using Array = Tumbleweed.Array;
using System = System;
using Immutable = Tumbleweed.Scalar.Immutable;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Array.Dimension.Multi.Function.Result;

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
		new Scalar.Value.Actual.Actual<T>(
			new Immutable::Function.Result.Actual
				<Any<T>>
				(function))
	)
	{
	}
}