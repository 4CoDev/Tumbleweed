using TumbleGD.Nodes.BatchMaps.Spatial.Batches;
using Tumbleweed.Arrays;
using Tumbleweed.Collections;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities;

public sealed class EntitiesOfBatch : CollectionEnvelope<ISpatialEntity>
{
	public EntitiesOfBatch(ISpatialBatch batch) : base
	(
		new CollectionOfFunction<ISpatialEntity>(
			() => batch.Entities)
	)
	{
	}

}