using DotGod.Nodes.BatchMaps.Spatial.Batches;
using Tumbleweed.Arrays;
using Tumbleweed.Collections;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities;

public sealed class EntitiesOfBatch : CollectionEnvelope<ISpatialEntity>
{
	public EntitiesOfBatch(IBatch batch) : base
	(
		new CollectionOfFunction<ISpatialEntity>(
			() => batch.Entities)
	)
	{
	}

}