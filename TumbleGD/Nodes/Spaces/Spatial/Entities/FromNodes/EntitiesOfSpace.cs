using Godot;
using Tumbleweed.Collections;
using Tumbleweed.Elements.FromStorages;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

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