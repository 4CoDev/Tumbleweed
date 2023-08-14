using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Unmeasured.Subbatch.NonNullable.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new Scalar.Value.One(
			new Nullable.At.Index.One(batch, index))
	)
	{
	}
}