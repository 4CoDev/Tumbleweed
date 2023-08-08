using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Spatial.Batch.Have.Subbatch.By;

public sealed class Index : Tumbleweed.Boolean.Envelope
{
	public Index
	(
		Any batch,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new Tumbleweed.Scalar.Nullable.Has.Value(
			new Nullable.Subbatch.By.Index(batch, index))
	)
	{
	}
}