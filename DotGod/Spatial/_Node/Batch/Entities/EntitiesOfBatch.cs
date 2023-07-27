using Tumbleweed.Collection;

namespace DotGod.Spatial._Node.Batch.Entities;

public sealed class EntitiesOfBatch : CollectionEnvelope<ISpatialEntity>
{
	public EntitiesOfBatch(Any batch) : base
	(
		new CollectionOfFunction<ISpatialEntity>(
			() => batch.Entities)
	)
	{
	}

}