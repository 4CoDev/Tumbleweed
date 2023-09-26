using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate;
using Tumbleweed.Mathematics.Number.Natural;
using Immutable = Tumbleweed.Scalar.Immutable;
using Array = Tumbleweed.Array;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.From.Array.Spatial.At;

public sealed class Index<T> : Immutable::Envelope<T>
{
	public Index
	(
		Array::Any<T> array, Mathematics.Geometry.Stereometry.Point.Generic.Any<Any> index
	) : base
	(
		new Immutable::From.Array.At.Indices<T>(
			array,
			new Enumerable<Any>(index))
	)
	{
	}
}