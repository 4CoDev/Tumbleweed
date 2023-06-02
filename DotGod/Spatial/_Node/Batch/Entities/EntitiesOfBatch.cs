using Tumbleweed._Collection;

namespace DotGod.Spatial._Node.Batch.Entities;

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