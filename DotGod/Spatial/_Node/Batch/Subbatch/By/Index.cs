using Tumbleweed.Number.Natural;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial._Node.Batch.Subbatch.By;

public sealed class Index : Batch.Envelope
{
	public Index
	(
		Batch.Any batch,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new Value.Of.Nullable(
			new Nullable.Subbatch.By.Index(batch, index))
	)
	{
	}
}