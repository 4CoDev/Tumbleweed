using Enumerable = Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using SCG = System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Item.Every.Scalar.Of;

public sealed class Value<T> : Enumerable::Envelope<Scalar::Any<T>>
{
	public Value(SCG::IEnumerable<T> enumerable) : base
	(
		new Enumerable::Selected<T, Scalar::Any<T>>
		(
			enumerable,
			value => new Tumbleweed.Scalar.Of.Value<T>(value)
		)
	)
	{
	}
}