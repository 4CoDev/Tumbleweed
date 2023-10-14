using Tumbleweed.Mathematics.Number.Natural;
using Mutable = Tumbleweed.Scalar.Mutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Multi.Item;

public sealed class Index<T> : Mutable::Envelope<T>
{
	public Index
	(
		Any<T> array,
		SCG::IEnumerable<Any> indices
	) : base
	(
		new Mutable::Function.Result<T>(
			() => array[indices])
	)
	{
	}
}