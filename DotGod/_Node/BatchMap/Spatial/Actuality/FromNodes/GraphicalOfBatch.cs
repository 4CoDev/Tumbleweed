using DotGod._Node.BatchMap.Actuality;
using DotGod._Node.BatchMap.Spatial.Entities.FromNodes;
using DotGod._Node.BatchMap.Spatial.Entities.Meshes;
using DotGod._Node.FromTree;
using DotGod._Node.Mesh;
using DotGod.Geometry.Spatial.Graphical._Mesh;
using Godot;
using Tumbleweed.Mutable;
using Tumbleweed.Scalar;

namespace DotGod._Node.BatchMap.Spatial.Actuality.FromNodes;

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
		mesh.Value =
			new MeshFromEntities(
				new EntitiesOfBatch(node));
	}

	private readonly IMutable<IMesh> mesh;

	private readonly IScalar<Node3D> node;
}