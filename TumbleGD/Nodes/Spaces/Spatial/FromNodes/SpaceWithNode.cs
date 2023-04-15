using Godot;
using TumbleGD.Nodes.Spaces.Spatial.Entities;
using TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes;
using Tumbleweed.Arrays;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.FromNodes;

public sealed class SpaceWithNode : ISpatialSpace
{
	public SpaceWithNode(IScalar<Node3D> node) =>
		this.node = node;

	public IArray<ISpatialSpace> Subspaces =>
		new SubspacesOfNode(node);

	public ICollection<ISpatialEntity> Entities =>
		new EntitiesOfSpace(node);

	private readonly IScalar<Node3D> node;
}