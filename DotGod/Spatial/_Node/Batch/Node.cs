using DotGod._Node.Children;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Spatial._Node.Batch;

public sealed class Node : Envelope<Node3D>
{
	public Node() : base
	(
		new Tumbleweed.Scalar.Function.Result<Node3D>(Function)
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