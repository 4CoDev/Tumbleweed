using Enumerable = Tumbleweed.Enumerable;
using Option = Tumbleweed.Property.Option;

namespace Tumbleweed.Property.Option.From.System;

public sealed class Multiple<T> : Enumerable::Envelope<Option::Any<T>>
{
	public Multiple(IEnumerable<T?> values) : base
	(
		new Enumerable::Selected<T?, Any<T>>(
			values,
			value => new Option::From.System.One<T>(value))
	)
	{
	}
}