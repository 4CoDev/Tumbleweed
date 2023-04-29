using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromStorages;
using Tumbleweed.Scalars;
using Tumbleweed.Storages.Elements;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities.FromNodes.Nodes;

public sealed class CurrentOfBatch : EnumerableEnvelope<Node>
{
	public CurrentOfBatch(IScalar<Node3D> space) : base
	(
		new EnumerableOfElement<Node>(
			new GlobalWithKey<IEnumerable<Node>>(
				space, "Entities.Nodes.Current"))
	)
	{
	}
}