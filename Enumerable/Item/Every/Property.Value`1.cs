using Tumbleweed.Property.Output;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Property = Tumbleweed.Property;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Item.Every.Property;

public sealed class Value<T> : Enumerable::Envelope<T>
{
	public Value
	(
		SCG::IEnumerable<Any<T>> enumerable
	) : base
	(
		new Enumerable::Selected<Any<T>, T>(
			enumerable,
			property => property.Value)
	)
	{
	}
}