using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using DotGod.Node.Batch.Actuality;
using DotGod.Node.Spatial.Batch.Entities.FromNodes;
using DotGod.Node.Spatial.Batch.Entities.Meshes;
using Godot;
using Mutable = Tumbleweed.Scalar.Mutable;
using Immutable = Tumbleweed.Scalar.Immutable;

namespace DotGod.Node.Spatial.Batch.Actuality.FromNodes;

public sealed class GraphicalOfBatch : ISpaceActuality
{
	public GraphicalOfBatch(Immutable::Any<Node3D> node)
	{
		this.node = node;
		mesh = new DotGod.Node.Mesh.Mutable(
			new DotGod.Node.On.Path.From.Scene.Lazy<MeshInstance3D>(node, "Mesh"));
	}

	public void Update()
	{
		mesh.Value =
			new MeshFromEntities(
				new EntitiesOfBatch(node));
	}

	private readonly Mutable::Any<Geometry.Spatial.Concave.Graphical.Mesh.Any> mesh;

	private readonly Immutable::Any<Node3D> node;
}