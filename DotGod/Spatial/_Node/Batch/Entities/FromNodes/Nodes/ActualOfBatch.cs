using Godot;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial._Node.Batch.Entities.FromNodes.Nodes;

public sealed class ActualOfBatch : Tumbleweed.Enumerable.Envelope<Godot.Node>
{
	public ActualOfBatch(Any<Node3D> space) : base
	(
		new Result<Godot.Node>(
			() => Function(space))
	)
	{
	}

	private static IEnumerable<Godot.Node> Function
	(Any<Node3D> space
	)
	{
		IEnumerable<Tumbleweed.Scalar.Nullable.Any<Godot.Node>> nullables = new ActualNullablesOfBatch(space);
		foreach (Tumbleweed.Scalar.Nullable.Any<Godot.Node> nullable in nullables)
			if (nullable.HasValue.State)
				yield return nullable.Value;
	}
}