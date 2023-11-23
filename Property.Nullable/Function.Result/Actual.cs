using Nullable = Tumbleweed.Property.Nullable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;
using Boolean = Tumbleweed.Mathematics.Boolean;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Nullable.Function;

public sealed class Actual<T> : Nullable::Any<T>
{
	public Actual
	(
		System::Func<Nullable::Any<T>> function
	) : this
	(
		new Function::From.System
			<Nullable::Any<T>>
			(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<Nullable::Any<T>> function
	)
	{
		this.function = function;
	}

	public T Value =>
		function.Result.Value;

	public Boolean::Any HasValue =>
		function.Result.HasValue;

	private readonly Function::Any<Nullable::Any<T>> function;
}