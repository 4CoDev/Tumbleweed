using DotGod._Node.BatchMap.Spatial.Batches;
using Tumbleweed._Collection;

namespace DotGod._Node.BatchMap.Spatial.Entities;

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