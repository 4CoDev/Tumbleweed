using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate;
using Property = Tumbleweed.Property.Output;
using Array = Tumbleweed.Array;

using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.From.Array.Spatial.At;

public sealed class Index<T> : Property::Envelope<T>
{
	public Index
	(Tumbleweed.Array.Dimension.Multi.Any<T> array, Mathematics.Vector.Spatial.Generic.Any<Any> index
	) : base
	(
		new Property::From.Array.At.Indices<T>(
			array,
			new Enumerable<Any>(index))
	)
	{
	}
}