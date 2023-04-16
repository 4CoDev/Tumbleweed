using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromStorages;
using Tumbleweed.Scalars;
using Tumbleweed.Storages.Elements;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes.Nodes;

public sealed class CurrentOfSpace : EnumerableEnvelope<Node>
{
	public CurrentOfSpace(IScalar<Node3D> space) : base
	(
		new EnumerableOfElement<Node>(
			new GlobalWithKey<IEnumerable<Node>>(
				space, "Entities.Nodes.Current"))
	)
	{
	}
}