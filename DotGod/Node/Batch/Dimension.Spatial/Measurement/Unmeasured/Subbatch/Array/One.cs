using Tumbleweed.Array.Dimension.Multi;
using Tumbleweed.Array.Dimension.Multi.Function.Result;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Subbatch.Array;

public sealed class One : Envelope<Tumbleweed.Scalar.Nullable.Any<Any>>
{
	public One(Any batch) : base
	(
		new Actual<Tumbleweed.Scalar.Nullable.Any<Any>>(
			() => batch.Subbatches)
	)
	{
	}

}