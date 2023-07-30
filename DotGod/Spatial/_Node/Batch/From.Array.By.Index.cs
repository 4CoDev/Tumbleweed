using Tumbleweed.Array;
using Tumbleweed.Number.Natural;
using Tumbleweed.Point.Spatial;

// ReSharper disable once CheckNamespace
namespace DotGod.Spatial._Node.Batch.From.Array.By;

public sealed class Index : Envelope
{
	public Index
	(Tumbleweed.Array.Any<Batch.Any> array, Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Natural.Any> indices
	) : base
	(
		new Value.Of.Scalar(
			new Tumbleweed.Scalar.Immutable.From.Array.Spatial.At.Index<Batch.Any>(
				array, 
				indices))
	)
	{
	}
}