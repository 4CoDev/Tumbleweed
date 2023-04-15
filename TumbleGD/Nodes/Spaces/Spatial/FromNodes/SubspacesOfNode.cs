using Godot;
using Tumbleweed.Arrays;
using Tumbleweed.Elements.FromStorages;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.FromNodes;

public sealed class SubspacesOfNode : ArrayEnvelope<ISpatialSpace>
{
	public SubspacesOfNode(IScalar<Node3D> node) : base
	(
		new ArrayOfElement<ISpatialSpace>(
			new GlobalWithKey<IArray<ISpatialSpace>>(
				node, "Subspaces"))
	)
	{
	}
}