using Scalar = Tumbleweed.Scalar;
using Array = Tumbleweed.Array;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;
using Mutable = Tumbleweed.Mutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.From.Array.At;

public sealed class Indices<T> : Scalar::Envelope<T>
{
	public Indices
	(
		Array::Any<T> array,
		SCG::IEnumerable<Natural::Any> indices
	) : base
	(
		new Mutable::Value<T>(
			new Array::Item.At.Index<T>(array, indices))
	)
	{
	}
}