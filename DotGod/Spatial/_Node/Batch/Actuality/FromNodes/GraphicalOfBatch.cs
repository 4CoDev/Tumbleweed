using DotGod._Node.Batch.Actuality;
using DotGod._Node.FromTree;
using DotGod._Node.Mesh;
using DotGod.Spatial._Node.Batch.Entities.FromNodes;
using DotGod.Spatial._Node.Batch.Entities.Meshes;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Mutable = Tumbleweed.Scalar.Mutable;
using Immutable = Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial._Node.Batch.Actuality.FromNodes;

public sealed class GraphicalOfBatch : ISpaceActuality
{
	public GraphicalOfBatch(Immutable::Any<Node3D> node)
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

	private readonly Mutable::Any<IMesh> mesh;

	private readonly Immutable::Any<Node3D> node;
}