using Enumerable = Tumbleweed.Enumerable;
using Nullable = Tumbleweed.Property.Nullable;

namespace Tumbleweed.Property.Nullable.From.System;

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