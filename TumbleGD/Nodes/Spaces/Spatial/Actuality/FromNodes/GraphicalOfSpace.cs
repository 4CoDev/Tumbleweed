using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Nodes.FromTree;
using TumbleGD.Nodes.Meshes;
using TumbleGD.Nodes.Spaces.Actuality;
using TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes;
using TumbleGD.Nodes.Spaces.Spatial.Entities.Meshes;
using Tumbleweed.Mutables;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Actuality.FromNodes;

public sealed class GraphicalOfSpace : ISpaceActuality
{
	public GraphicalOfSpace(IScalar<Node3D> node)
	{
		this.node = node;
		mesh = new MutableOfNode(
			new LazyOnPath<MeshInstance3D>(node, "Mesh"));
	}

	public void Update()
	{
		mesh.Value =
			new MeshFromEntities(
				new EntitiesOfSpace(node));
	}

	private readonly IMutable<IMesh> mesh;

	private readonly IScalar<Node3D> node;
}