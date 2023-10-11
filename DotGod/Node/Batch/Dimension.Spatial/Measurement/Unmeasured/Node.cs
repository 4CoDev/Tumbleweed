using DotGod.Node.Member.Children;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;

public sealed class Node : Envelope<Godot.Node3D>
{
	public Node() : base
	(
		new Actual<Godot.Node3D>(Function)
	)
	{
	}

	private static Godot.Node3D Function()
	{
		var space = new Godot.Node3D { Name = "Space" };
		var mesh = new Godot.MeshInstance3D { Name = "Mesh" };
		new Actual(space).Add(mesh);
		return space;
	}
}