using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial;

public sealed class SpaceNode : ScalarEnvelope<Node>
{
	public SpaceNode() : base
	(
		new ValueOfFunction<Node>(Function)
	)
	{
	}

	private static Node Function()
	{
		Node space = new Node { Name = "Space" };
		MeshInstance3D mesh = new MeshInstance3D { Name = "Mesh" };
		space.AddChild(mesh);
		return space;
	}
}