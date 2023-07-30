using Mutable = Tumbleweed.Scalar.Mutable;
using Array = Tumbleweed.Array;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Item.At;

public sealed class Index<T> : Mutable::Envelope<T>
{
	public Index
	(
		Array::Any<T> array,
		SCG::IEnumerable<Natural::Any> indices
	) : base
	(
		new Mutable::Function.Result<T>(
			() => array[indices])
	)
	{
	}
}