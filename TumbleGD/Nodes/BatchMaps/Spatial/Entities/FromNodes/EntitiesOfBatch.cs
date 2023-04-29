using Godot;
using Tumbleweed.Collections;
using Tumbleweed.Collections.FromStorages;
using Tumbleweed.Scalars;
using Tumbleweed.Storages.Elements;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities.FromNodes;

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