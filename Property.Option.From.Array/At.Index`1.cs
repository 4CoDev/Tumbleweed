using Option = Tumbleweed.Property.Option;
using Array = Tumbleweed.Array;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Option.From.Array.At;

public sealed class Index<T> : Option::Envelope<T>
{
	public Index
	(
		Array::Dimension.Multi.Any<Option::Any<T>> array,
		SCG::IEnumerable<Natural::Any> indices
	) : base
	(
		new Option::Function.Actual<T>(
			() => array[indices].Value)
	)
	{
	}
}