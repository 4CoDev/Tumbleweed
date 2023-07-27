using DotGod.Spatial._Node.Batch;
using Tumbleweed.Array;
using Tumbleweed.Array.Function;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Nullable.Subbatch.Array.Of;

public sealed class Batch : Tumbleweed.Array.Envelope<Tumbleweed.Nullable.Any<Any>>
{
	public Batch(Any batch) : base
	(
		new Tumbleweed.Array.Function.Result<Tumbleweed.Nullable.Any<Any>>(
			() => batch.Subbatches)
	)
	{
	}

}