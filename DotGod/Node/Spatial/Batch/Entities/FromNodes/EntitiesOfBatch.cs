using Godot;
using Tumbleweed.Collection;
using Tumbleweed.Collection.FromStorages;
using Tumbleweed.Storage.Record.By.Key;

namespace DotGod.Node.Spatial.Batch.Entities.FromNodes;

public sealed class EntitiesOfBatch : CollectionEnvelope<ISpatialEntity>
{
	public EntitiesOfBatch(Tumbleweed.Scalar.Immutable.Any<Node3D> node) : base
	(
		new CollectionOfElement<ISpatialEntity>(
			new Global<ICollection<ISpatialEntity>>(
				node, "Entities"))
	)
	{
	}
}