using Godot;
using Tumbleweed.Collection;
using Tumbleweed.Collection.FromStorages;
using Tumbleweed.Scalar;
using Tumbleweed.Storage.Record;
using Tumbleweed.Storage.Record.By.Key;

namespace DotGod.Spatial._Node.Batch.Entities.FromNodes;

public sealed class EntitiesOfBatch : CollectionEnvelope<ISpatialEntity>
{
	public EntitiesOfBatch(Tumbleweed.Scalar.Any<Node3D> node) : base
	(
		new CollectionOfElement<ISpatialEntity>(
			new Global<ICollection<ISpatialEntity>>(
				node, "Entities"))
	)
	{
	}
}