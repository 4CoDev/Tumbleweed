using DotGod._Node.Batch.Actuality;
using DotGod._Node.FromTree;
using DotGod._Node.Mesh;
using DotGod.Spatial._Node.Batch.Entities.FromNodes;
using DotGod.Spatial._Node.Batch.Entities.Meshes;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed.Mutable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch.Actuality.FromNodes;

public sealed class GraphicalOfBatch : ISpaceActuality
{
	public GraphicalOfBatch(Tumbleweed.Scalar.Any<Node3D> node)
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

	private readonly Tumbleweed.Mutable.Any<IMesh> mesh;

	private readonly Tumbleweed.Scalar.Any<Node3D> node;
}