using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced;

public sealed class Node : Envelope<Node3D>
{
	public Node() : base
	(
		new Actual<Node3D>(Function)
	)
	{
	}

	private static Node3D Function()
	{
		Node3D space = new Node3D { Name = "Space" };
		MeshInstance3D mesh = new MeshInstance3D { Name = "Mesh" };
		new Children(space).Add(mesh);
		return space;
	}
}