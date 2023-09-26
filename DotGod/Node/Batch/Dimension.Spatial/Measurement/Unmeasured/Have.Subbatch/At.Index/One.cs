using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;


namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Have.Subbatch.At.Index;

public sealed class One : Tumbleweed.Mathematics.Boolean.Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Mathematics.Number.Natural.Any> index
	) : base
	(
		new Tumbleweed.Scalar.Nullable.Has.Value(
			new Unmeasured.Subbatch.Nullable.At.Index.One(batch, index))
	)
	{
	}
}