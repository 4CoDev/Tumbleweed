using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Nodes.BatchMaps.Actuality;
using TumbleGD.Nodes.BatchMaps.Spatial.Entities.FromNodes;
using TumbleGD.Nodes.BatchMaps.Spatial.Entities.Meshes;
using TumbleGD.Nodes.FromTree;
using TumbleGD.Nodes.Meshes;
using Tumbleweed.Mutables;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Actuality.FromNodes;

public sealed class GraphicalOfBatch : ISpaceActuality
{
	public GraphicalOfBatch(IScalar<Node3D> node)
	{
		this.node = node;
		mesh = new MutableOfNode(
			new LazyOnPath<MeshInstance3D>(node, "Mesh"));
	}

	public void Update()
	{
		mesh.Variable =
			new MeshFromEntities(
				new EntitiesOfBatch(node));
	}

	private readonly IMutable<IMesh> mesh;

	private readonly IScalar<Node3D> node;
}