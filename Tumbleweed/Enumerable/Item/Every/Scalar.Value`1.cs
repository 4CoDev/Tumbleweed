using Tumbleweed.Scalar.Immutable;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Item.Every.Scalar;

public sealed class Value<T> : Enumerable::Envelope<T>
{
	public Value
	(
		SCG::IEnumerable<Any<T>> enumerable
	) : base
	(
		new Enumerable::Selected<Any<T>, T>(
			enumerable,
			scalar => scalar.Value)
	)
	{
	}
}