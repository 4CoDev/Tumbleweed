using Tumbleweed.Property.Option;
using Tumbleweed.Property.Option.From.Array.Spatial.At;
using NaturalPoint = Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<
		Tumbleweed.Mathematics.Number.Natural.Any>;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Subbatch.Option.At.Index;

public sealed class One : Envelope<Any>
{
	public One
	(
		Any batch,
		NaturalPoint index
	) : base
	(
		new Index<Any>(
			new Array.One(batch),
			index)
	)
	{
	}
}