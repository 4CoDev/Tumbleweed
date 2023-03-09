using Godot;
using TumbleGD.Geometrics.Graphical.ArrayMeshes;
using TumbleGD.Nodes.FromTree.OfGodot;
using TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities;
using TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities.Meshes;
using Tumbleweed.Arrays;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical;

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