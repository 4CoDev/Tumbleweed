using Tumbleweed.Property.Output;
using Enumerable = Tumbleweed.Enumerable;
using Property = Tumbleweed.Property;
using SCG = System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Item.Every.Property.Of;

public sealed class Value<T> : Enumerable::Envelope<Any<T>>
{
	public Value(SCG::IEnumerable<T> enumerable) : base
	(
		new Enumerable::Selected<T, Any<T>>
		(
			enumerable,
			value => new Tumbleweed.Property.Output.With.Value<T>(value)
		)
	)
	{
	}
}