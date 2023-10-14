using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.System.Function.Result;
using Nullable = Tumbleweed.Scalar.Nullable;
using Immutable = Tumbleweed.Scalar.Immutable;


namespace Tumbleweed.Scalar.Nullable.From.System;

public sealed class One<T> : Nullable::Envelope<T>
{
	public One(T? value) : this
	(
		new Immutable::With.Value<T?>(value)
	)
	{
	}
	
	public One(Immutable.Any<T?> scalar) : base
	(
		new Nullable::With.Members<T>(
			scalar!,
			new One(
				new Actual(
					() => scalar.Value != null)))
	)
	{
	}
}