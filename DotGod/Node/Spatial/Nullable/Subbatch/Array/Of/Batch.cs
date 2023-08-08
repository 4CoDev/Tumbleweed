using DotGod.Node.Spatial.Batch;

namespace DotGod.Node.Spatial.Nullable.Subbatch.Array.Of;

public sealed class Batch : Tumbleweed.Array.Envelope<Tumbleweed.Scalar.Nullable.Any<Any>>
{
	public Batch(Any batch) : base
	(
		new Tumbleweed.Array.Function.Result<Tumbleweed.Scalar.Nullable.Any<Any>>(
			() => batch.Subbatches)
	)
	{
	}

}