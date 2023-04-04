using Godot;
using Tumbleweed.Elements.FromStorages;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes;

public sealed class EntitiesOfSpace : EnumerableEnvelope<ISpatialEntity>
{
	public EntitiesOfSpace(IScalar<Node3D> node) : base
	(
		new EnumerableOfElement<ISpatialEntity>(
			new GlobalWithKey<IEnumerable<ISpatialEntity>>(
				node, "Entities"))
	)
	{
	}
}