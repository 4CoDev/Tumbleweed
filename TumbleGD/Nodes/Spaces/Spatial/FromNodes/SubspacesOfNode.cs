using Godot;
using Tumbleweed.Arrays;
using Tumbleweed.Arrays.FromStorages;
using Tumbleweed.Scalars;
using Tumbleweed.Storages.Elements;

namespace TumbleGD.Nodes.Spaces.Spatial.FromNodes;

public sealed class SubspacesOfNode : ArrayEnvelope<ISpatialSpace>
{
	public SubspacesOfNode(IScalar<Node3D> node) : base
	(
		new ArrayOfStorageElement<ISpatialSpace>(
			new GlobalWithKey<IArray<ISpatialSpace>>(
				node, "Subspaces"))
	)
	{
	}
}