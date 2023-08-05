using DotGod.Node.Batch.Actuality;
using DotGod.Node.Mesh;
using DotGod.Node.On.Path.From.Scene;
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
		mesh = new DotGod.Node.Mesh.Mutable(
			new DotGod.Node.On.Path.From.Scene.Lazy<MeshInstance3D>(node, "Mesh"));
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