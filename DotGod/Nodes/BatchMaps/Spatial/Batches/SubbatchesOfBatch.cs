using Tumbleweed.Arrays;
using Tumbleweed.Nullability;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public sealed class SubbatchesOfBatch : NullableEnvelope<IArray<ISpatialBatch>>
{
	public SubbatchesOfBatch(ISpatialBatch batch) : base
	(
		new NullableOfFunction<IArray<ISpatialBatch>>(
			() => batch.Subbatches)
	)
	{
	}

}