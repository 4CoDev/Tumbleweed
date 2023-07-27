using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Of;

public sealed class Value<T> : Envelope<T>
{
	public Value(T value) : base
	(
		new Function.Result<T>(
			() => value)
	)
	{
	}
}