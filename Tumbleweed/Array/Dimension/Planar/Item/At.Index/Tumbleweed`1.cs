using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Vector.Planar.Generic.Coordinate;
using Tumbleweed.Scalar.Immutable.From.Array.At;
using Scalar = Tumbleweed.Scalar;
using Array = Tumbleweed.Array;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Planar.Item.At.Index;

public sealed class Tumbleweed<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Tumbleweed
	(
		Array::Any<T> array, Mathematics.Vector.Planar.Generic.Any<Any> index
	) : base
	(
		new Indices<T>(
			array,
			new Enumerable<Any>(index))
	)
	{
	}
}