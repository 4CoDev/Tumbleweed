using DotGod._Node.Children;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch;

public sealed class BatchNode : ScalarEnvelope<Node3D>
{
	public BatchNode() : base
	(
		new ResultOfFunction<Node3D>(Function)
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