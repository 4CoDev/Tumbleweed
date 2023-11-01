using Tumbleweed.Array.Dimension.Multi.Item;
using Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property.Output;
using Array = Tumbleweed.Array;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.From.Array.At;

public sealed class Indices<T> : Property::Envelope<T>
{
	public Indices
	(Tumbleweed.Array.Dimension.Multi.Any<T> array,
		SCG::IEnumerable<Any> indices
	) : base
	(
		new Index<T>(array, indices)
	)
	{
	}
}