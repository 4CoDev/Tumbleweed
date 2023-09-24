using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Point.Spatial.Generic.Coordinate;
using Tumbleweed.Scalar.Immutable.From.Array.At;
using Scalar = Tumbleweed.Scalar;
using Array = Tumbleweed.Array;
using Point = Tumbleweed.Point.Spatial;
using Natural = Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Array.Dimension.Spatial.Item.At.Index;

public sealed class Tumbleweed<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Tumbleweed
	(
		Array::Any<T> array, Point.Spatial.Generic.Any<Any> indices
	) : base
	(
		new Indices<T>(
			array,
			new Enumerable<Any>(indices))
	)
	{
	}
}