using Immutable = Tumbleweed.Scalar.Immutable;
using Array = Tumbleweed.Array;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.From.Array.At;

public sealed class Indices<T> : Immutable::Envelope<T>
{
	public Indices
	(
		Array::Any<T> array,
		SCG::IEnumerable<Natural::Any> indices
	) : base
	(
		new Array::Item.At.Index<T>(array, indices)
	)
	{
	}
}