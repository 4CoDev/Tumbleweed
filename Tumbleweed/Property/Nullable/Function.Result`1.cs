using Nullable = Tumbleweed.Property.Nullable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Nullable.Function;

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
		new Nullable::Property.Value.One<T>(
			new Property::Function.Result.Actual
				<Nullable::Any<T>>
				(function))
	)
	{
	}
}