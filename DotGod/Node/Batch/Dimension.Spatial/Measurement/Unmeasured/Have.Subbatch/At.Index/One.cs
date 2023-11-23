using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Have.Subbatch.At.Index;

public sealed class One : Tumbleweed.Mathematics.Boolean.Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Mathematics.Number.Natural.Any> index
	) : base
	(
		new Tumbleweed.Property.Option.Has.Value(
			new Unmeasured.Subbatch.Option.At.Index.One(batch, index))
	)
	{
	}
}