using Godot;
using TumbleGD.Nodes.Children;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial;

public sealed class SpaceNode : ScalarEnvelope<Node3D>
{
	public SpaceNode() : base
	(
		new ValueOfFunction<Node3D>(Function)
	)
	{
	}

	private static Node3D Function()
	{
		Node3D space = new Node3D { Name = "Space" };
		MeshInstance3D mesh = new MeshInstance3D { Name = "Mesh" };
		new ChildrenOfNode(space).Add(mesh);
		return space;
	}
}