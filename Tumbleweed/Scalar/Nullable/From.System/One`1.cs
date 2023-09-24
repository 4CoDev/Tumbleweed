using Tumbleweed.Mathematics.Boolean.From.System;
using Nullable = Tumbleweed.Scalar.Nullable;
using Immutable = Tumbleweed.Scalar.Immutable;
using Boolean = Tumbleweed.Boolean;

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
				new Boolean::System.Function.Result(
					() => scalar.Value != null)))
	)
	{
	}
}