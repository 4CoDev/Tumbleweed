using Tumbleweed.Arrays;
using Tumbleweed.Nullables;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

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