using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Spatial._Node.Batch.Entities.FromNodes.Nodes;

public sealed class ActualOfBatch : Envelope<Godot.Node>
{
	public ActualOfBatch(Tumbleweed.Scalar.Any<Node3D> space) : base
	(
		new Result<Godot.Node>(
			() => Function(space))
	)
	{
	}

	private static IEnumerable<Godot.Node> Function
	(Tumbleweed.Scalar.Any<Node3D> space
	)
	{
		IEnumerable<Tumbleweed.Nullable.Any<Godot.Node>> nullables = new ActualNullablesOfBatch(space);
		foreach (Tumbleweed.Nullable.Any<Godot.Node> nullable in nullables)
			if (nullable.HasValue.State)
				yield return nullable.Value;
	}
}