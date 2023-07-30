using Tumbleweed.Boolean;
using Tumbleweed.Number.Natural;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial._Node.Batch.Have.Subbatch.By;

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