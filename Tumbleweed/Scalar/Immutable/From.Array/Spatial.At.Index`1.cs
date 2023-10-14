using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate;
using Immutable = Tumbleweed.Scalar.Immutable;
using Array = Tumbleweed.Array;

using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.From.Array.Spatial.At;

public sealed class Index<T> : Immutable::Envelope<T>
{
	public Index
	(Tumbleweed.Array.Dimension.Multi.Any<T> array, Mathematics.Vector.Spatial.Generic.Any<Any> index
	) : base
	(
		new Immutable::From.Array.At.Indices<T>(
			array,
			new Enumerable<Any>(index))
	)
	{
	}
}