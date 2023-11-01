using Tumbleweed.Array.Dimension.Multi;
using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Vector.Planar.Generic.Coordinate;
using Tumbleweed.Property.Output.From.Array.At;
using Property = Tumbleweed.Property;
using Array = Tumbleweed.Array;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Planar.Item.At.Index;

public sealed class Tumbleweed<T> : Tumbleweed.Property.Output.Envelope<T>
{
	public Tumbleweed
	(
		Any<T> array, Mathematics.Vector.Planar.Generic.Any<Any> index
	) : base
	(
		new Indices<T>(
			array,
			new Enumerable<Any>(index))
	)
	{
	}
}