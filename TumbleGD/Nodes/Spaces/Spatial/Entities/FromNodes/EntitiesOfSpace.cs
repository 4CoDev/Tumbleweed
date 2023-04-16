using Godot;
using Tumbleweed.Collections;
using Tumbleweed.Collections.FromStorages;
using Tumbleweed.Scalars;
using Tumbleweed.Storages.Elements;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes;

public sealed class EntitiesOfSpace : CollectionEnvelope<ISpatialEntity>
{
	public EntitiesOfSpace(IScalar<Node3D> node) : base
	(
		new CollectionOfElement<ISpatialEntity>(
			new GlobalWithKey<ICollection<ISpatialEntity>>(
				node, "Entities"))
	)
	{
	}
}