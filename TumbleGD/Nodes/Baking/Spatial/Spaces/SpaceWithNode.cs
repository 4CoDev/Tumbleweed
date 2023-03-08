using Godot;
using TumbleGD.Geometrics.Graphical.ArrayMeshes;
using TumbleGD.Nodes.Baking.Spatial.Entities;
using TumbleGD.Nodes.Baking.Spatial.Entities.Meshes;
using TumbleGD.Nodes.FromTree.OfGodot;
using Tumbleweed.Arrays;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Baking.Spatial.Spaces;

public sealed class SpaceWithNode : IBakingSpace
{
	public SpaceWithNode
	(
		IScalar<Node> node,
		IArray<IBakingSpace> spaces,
		IEnumerable<IBakingEntity> entities
	)
	{
		this.node = node;
		Spaces = spaces;
		Entities = entities;
	}
	
	public IArray<IBakingSpace> Spaces { get; }

	public IEnumerable<IBakingEntity> Entities { get; }

	public void Update()
	{
		Mesh.Mesh = new ArrayMeshFromSurfaces(
			new MeshFromEntities(Entities)).Value;
	}

	private MeshInstance3D Mesh =>
		new NodeOnPath<MeshInstance3D>(node, "Mesh").Value;
	
	private readonly IScalar<Node> node;
}