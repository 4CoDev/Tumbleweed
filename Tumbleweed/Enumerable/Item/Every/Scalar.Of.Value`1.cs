using Tumbleweed.Scalar.Immutable;
using Enumerable = Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using SCG = System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Item.Every.Scalar.Of;

public sealed class Value<T> : Enumerable::Envelope<Any<T>>
{
	public Value(SCG::IEnumerable<T> enumerable) : base
	(
		new Enumerable::Selected<T, Any<T>>
		(
			enumerable,
			value => new Tumbleweed.Scalar.Immutable.With.Value<T>(value)
		)
	)
	{
	}
}