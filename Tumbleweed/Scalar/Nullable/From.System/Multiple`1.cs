using Enumerable = Tumbleweed.Enumerable;
using Nullable = Tumbleweed.Scalar.Nullable;

namespace Tumbleweed.Scalar.Nullable.From.System;

public sealed class Multiple<T> : Enumerable::Envelope<Nullable::Any<T>>
{
	public Multiple(IEnumerable<T?> values) : base
	(
		new Enumerable::Selected<T?, Any<T>>(
			values,
			value => new Nullable::From.System.One<T>(value))
	)
	{
	}
}