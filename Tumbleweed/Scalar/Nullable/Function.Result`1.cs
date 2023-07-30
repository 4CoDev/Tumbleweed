using Nullable = Tumbleweed.Scalar.Nullable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Immutable = Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.Function;

public sealed class Result<T> : Nullable::Envelope<T>
{
	public Result
	(
		System::Func<Nullable::Any<T>> function
	) : this
	(
		new Function::From.System<Nullable::Any<T>>(function)
	)
	{
	}
	
	public Result
	(
		Function::Any<Nullable::Any<T>> function
	) : base
	(
		new Nullable::Scalar.Value.One<T>(
			new Immutable::Function.Result.Actual
				<Nullable::Any<T>>
				(function))
	)
	{
	}
}