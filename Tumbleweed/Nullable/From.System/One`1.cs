using Tumbleweed.Boolean.System;
using Tumbleweed.Boolean.System.Function;
using Tumbleweed.Boolean.From.System;

namespace Tumbleweed.Nullable.From.System;

public sealed class One<T> : Nullable.Envelope<T>
{
	public One(T? value) : this
	(
		new Tumbleweed.Scalar.Of.Value<T?>(value)
	)
	{
	}
	
	public One(Scalar.Any<T?> scalar) : base
	(
		new Nullable.With.Members<T>(
			scalar!,
			new One(
				new Boolean.System.Function.Result(
					() => scalar.Value != null)))
	)
	{
	}
}