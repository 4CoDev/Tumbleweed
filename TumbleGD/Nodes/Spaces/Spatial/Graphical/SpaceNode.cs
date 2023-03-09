using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical;

public sealed class SpaceNode : ScalarEnvelope<Node>
{
	public SpaceNode() : base
	(
		new ValueOfDelegate<Node>(Function)
	)
	{
	}

	private static Node Function()
	{
		Node space = new Node();
		MeshInstance3D mesh = new MeshInstance3D();
		space.AddChild(mesh);
		return space;
	}
}