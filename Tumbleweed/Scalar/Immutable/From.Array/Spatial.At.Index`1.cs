using Immutable = Tumbleweed.Scalar.Immutable;
using Array = Tumbleweed.Array;
using Point = Tumbleweed.Point.Spatial;
using Natural = Tumbleweed.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.From.Array.Spatial.At;

public sealed class Index<T> : Immutable::Envelope<T>
{
	public Index
	(
		Array::Any<T> array,
		Point::Any<Natural::Any> index
	) : base
	(
		new Immutable::From.Array.At.Indices<T>(
			array,
			new Point::Coordinate.Enumerable<Natural::Any>(index))
	)
	{
	}
}