using Scalar = Tumbleweed.Scalar;
using Array = Tumbleweed.Array;
using Point = Tumbleweed.Point.Spatial;
using Natural = Tumbleweed.Number.Natural;

namespace Tumbleweed.Array.Dimension.Spatial.Item.At.Index;

public sealed class Tumbleweed<T> : Scalar::Envelope<T>
{
	public Tumbleweed
	(
		Array::Any<T> array,
		Point::Any<Natural::Any> indices
	) : base
	(
		new Scalar::From.Array.At.Indices<T>(
			array,
			new Point::Coordinate.Enumerable<Natural::Any>(indices))
	)
	{
	}
}