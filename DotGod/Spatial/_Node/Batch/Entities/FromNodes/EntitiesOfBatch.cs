using Godot;
using Tumbleweed._Collection;
using Tumbleweed._Collection.FromStorages;
using Tumbleweed.Scalar;
using Tumbleweed.Storage.Element;

namespace DotGod.Spatial._Node.Batch.Entities.FromNodes;

public sealed class EntitiesOfBatch : CollectionEnvelope<ISpatialEntity>
{
	public EntitiesOfBatch(IScalar<Node3D> node) : base
	(
		new CollectionOfElement<ISpatialEntity>(
			new GlobalWithKey<ICollection<ISpatialEntity>>(
				node, "Entities"))
	)
	{
	}
}