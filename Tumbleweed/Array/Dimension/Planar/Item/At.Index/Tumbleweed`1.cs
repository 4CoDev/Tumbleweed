using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Scalar.Immutable.From.Array.At;
using Scalar = Tumbleweed.Scalar;
using Array = Tumbleweed.Array;
using Planar = Tumbleweed.Point.Planar;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Planar.Item.At.Index;

public sealed class Tumbleweed<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Tumbleweed
	(
		Array::Any<T> array,
		Planar::Any<Any> index
	) : base
	(
		new Indices<T>(
			array,
			new Planar::Coordinate.Enumerable<Any>(index))
	)
	{
	}
}