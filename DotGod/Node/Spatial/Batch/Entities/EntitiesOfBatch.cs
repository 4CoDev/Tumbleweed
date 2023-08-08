using Tumbleweed.Collection;

namespace DotGod.Node.Spatial.Batch.Entities;

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