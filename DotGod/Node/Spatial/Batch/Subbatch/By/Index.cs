using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Spatial.Batch.Subbatch.By;

public sealed class Index : Envelope
{
	public Index
	(
		Any batch,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new DotGod.Spatial._Node.Batch.Value.Of.Nullable(
			new Nullable.Subbatch.By.Index(batch, index))
	)
	{
	}
}