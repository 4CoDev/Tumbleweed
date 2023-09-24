using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Subbatch.NonNullable.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Mathematics.Number.Natural.Any> index
	) : base
	(
		new Scalar.Value.One(
			new Nullable.At.Index.One(batch, index))
	)
	{
	}
}