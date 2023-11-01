using Tumbleweed.Property.Nullable;
using Tumbleweed.Property.Nullable.From.Array.Spatial.At;
using NaturalPoint = Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<
		Tumbleweed.Mathematics.Number.Natural.Any>;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Subbatch.Nullable.At.Index;

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