using Tumbleweed.Array.Dimension.Multi.Item;
using Tumbleweed.Mathematics.Number.Natural;
using Immutable = Tumbleweed.Scalar.Immutable;
using Array = Tumbleweed.Array;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.From.Array.At;

public sealed class Indices<T> : Immutable::Envelope<T>
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