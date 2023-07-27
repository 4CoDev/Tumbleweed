using Tumbleweed.Enumerable;

namespace Tumbleweed.Nullable.From.System;

public sealed class Multiple<T> : Enumerable.Envelope<Nullable.Any<T>>
{
	public Multiple(IEnumerable<T?> values) : base
	(
		new Selected<T?, Nullable.Any<T>>(
			values,
			value => new From.System.One<T>(value))
	)
	{
	}
}