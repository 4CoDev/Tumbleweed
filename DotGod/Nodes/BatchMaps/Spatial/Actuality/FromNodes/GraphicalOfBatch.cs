using DotGod.Geometrics.Graphical.Meshes;
using DotGod.Nodes.BatchMaps.Actuality;
using DotGod.Nodes.BatchMaps.Spatial.Entities.FromNodes;
using DotGod.Nodes.BatchMaps.Spatial.Entities.Meshes;
using DotGod.Nodes.FromTree;
using DotGod.Nodes.Meshes;
using Godot;
using Tumbleweed.Mutables;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Actuality.FromNodes;

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