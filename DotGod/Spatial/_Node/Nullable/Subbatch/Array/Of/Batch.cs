using DotGod.Spatial._Node.Batch;
using Tumbleweed.Array;
using Tumbleweed.Array.Function;

namespace DotGod.Spatial._Node.Nullable.Subbatch.Array.Of;

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