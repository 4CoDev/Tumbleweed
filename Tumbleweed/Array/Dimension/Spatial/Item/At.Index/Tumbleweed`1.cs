using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Scalar.Immutable.From.Array.At;
using Scalar = Tumbleweed.Scalar;
using Array = Tumbleweed.Array;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using Natural = Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Array.Dimension.Spatial.Item.At.Index;

public sealed class Tumbleweed<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Tumbleweed
	(
		Array::Any<T> array, Mathematics.Geometry.Stereometry.Point.Generic.Any<Any> indices
	) : base
	(
		new Indices<T>(
			array,
			new Enumerable<Any>(indices))
	)
	{
	}
}