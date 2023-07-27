using Tumbleweed.Array;
using Tumbleweed.Number.Natural;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Coordinate;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.From.Array.Spatial.At;

public sealed class Index<T> : Envelope<T>
{
	public Index
	(Tumbleweed.Array.Any<T> array, Point.Spatial.Any<Any> index
	) : base
	(
		new From.Array.At.Indices<T>(
			array,
			new Enumerable<Any>(index))
	)
	{
	}
}