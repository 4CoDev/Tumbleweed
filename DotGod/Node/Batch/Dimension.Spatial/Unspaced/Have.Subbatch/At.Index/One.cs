using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced.Have.Subbatch.At.Index;

public sealed class One : Tumbleweed.Boolean.Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new Tumbleweed.Scalar.Nullable.Has.Value(
			new Unspaced.Subbatch.Nullable.At.Index.One(batch, index))
	)
	{
	}
}