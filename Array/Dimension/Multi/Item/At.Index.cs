using Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property.Transput;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Multi.Item;

public sealed class Index<T> : Property::Envelope<T>
{
	public Index
	(
		Any<T> array,
		SCG::IEnumerable<Any> indices
	) : base
	(
		new Property::Function.Result<T>(
			() => array[indices])
	)
	{
	}
}