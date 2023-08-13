namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced.Subbatch.Array;

public sealed class One : Tumbleweed.Array.Envelope<Tumbleweed.Scalar.Nullable.Any<Any>>
{
	public One(Any batch) : base
	(
		new Tumbleweed.Array.Function.Result<Tumbleweed.Scalar.Nullable.Any<Any>>(
			() => batch.Subbatches)
	)
	{
	}

}