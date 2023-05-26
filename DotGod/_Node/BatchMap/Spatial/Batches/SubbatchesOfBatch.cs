using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod._Node.BatchMap.Spatial.Batches;

public sealed class SubbatchesOfBatch : NullableEnvelope<IArray<IBatch>>
{
	public SubbatchesOfBatch(IBatch batch) : base
	(
		new NullableOfFunction<IArray<IBatch>>(
			() => batch.Subbatches)
	)
	{
	}

}