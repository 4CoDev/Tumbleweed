using Godot;
using Tumbleweed._Collection;
using Tumbleweed._Collection.FromStorages;
using Tumbleweed.Scalar;
using Tumbleweed.Storage.Element;

namespace DotGod._Node.BatchMap.Spatial.Entities.FromNodes;

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