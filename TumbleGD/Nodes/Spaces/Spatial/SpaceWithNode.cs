using Godot;
using TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.ToGodot;
using TumbleGD.Nodes.Spaces.Spatial.Entities;
using TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes;
using TumbleGD.Nodes.Spaces.Spatial.Entities.Meshes;
using Tumbleweed.Arrays;
using Tumbleweed.Elements.FromStorages;
using Tumbleweed.Scalars;
using Tumbleweed.Storages;

namespace TumbleGD.Nodes.Spaces.Spatial;

public sealed class SpaceWithNode : ISpatialSpace
{
	public SpaceWithNode(IScalar<Node3D> node) =>
		this.node = node;

	public IArray<ISpatialSpace> Subspaces =>
		new SubspacesOfNode(node);

	public IEnumerable<ISpatialEntity> Entities =>
		new EntitiesOfSpace(node);

	private readonly IScalar<Node3D> node;
}