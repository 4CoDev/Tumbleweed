using Godot;
using TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.FromGodot;
using TumbleGD.Nodes.FromTree.OfGodot;
using TumbleGD.Nodes.Spaces.Spatial.Entities;
using TumbleGD.Nodes.Spaces.Spatial.Entities.Meshes;
using Tumbleweed.Arrays;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial;

public sealed class SpaceWithSpatial : ISpatialSpace
{
	public SpaceWithSpatial
	(
		IScalar<Node> node,
		IArray<ISpatialSpace> spaces,
		IEnumerable<ISpatialEntity> entities
	)
	{
		this.node = node;
		Spaces = spaces;
		Entities = entities;
	}
	
	public IArray<ISpatialSpace> Spaces { get; }

	public IEnumerable<ISpatialEntity> Entities { get; }

	public void Update()
	{
		Mesh.Mesh = new MeshFromMesh(
			new MeshFromEntities(Entities)).Value;
	}

	private MeshInstance3D Mesh =>
		new NodeOnPath<MeshInstance3D>(node, "Mesh").Value;
	
	private readonly IScalar<Node> node;
}