using Tumbleweed.Array.Dimension.Multi;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate;
using Tumbleweed.Scalar.Immutable.From.Array.At;
using Scalar = Tumbleweed.Scalar;
using Array = Tumbleweed.Array;

using Natural = Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Array.Dimension.Spatial.Item.At.Index;

public sealed class Tumbleweed<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Tumbleweed
	(
		Any<T> array, Mathematics.Vector.Spatial.Generic.Any<Any> indices
	) : base
	(
		new Indices<T>(
			array,
			new Enumerable<Any>(indices))
	)
	{
	}
}