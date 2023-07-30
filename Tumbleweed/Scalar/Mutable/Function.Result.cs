using Mutable = Tumbleweed.Scalar.Mutable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Immutable = Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Mutable.Function;

public sealed class Result<T> : Mutable::Envelope<T>
{
	public Result(System::Func<Mutable::Any<T>> function) : this
	(
		new Function::From.System
			<Mutable::Any<T>>
			(function)
	)
	{
	}

	public Result(Function::Any<Mutable::Any<T>> function) : base
	(
		new Mutable::Scalar.Value.One<T>(
			new Immutable::Function.Result.Actual
				<Mutable::Any<T>>
				(function))
	)
	{
	}
}