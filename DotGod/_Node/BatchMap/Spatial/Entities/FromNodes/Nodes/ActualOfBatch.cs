using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace DotGod._Node.BatchMap.Spatial.Entities.FromNodes.Nodes;

public sealed class ActualOfBatch : EnumerableEnvelope<Node>
{
	public ActualOfBatch(IScalar<Node3D> space) : base
	(
		new EnumerableOfFunction<Node>(
			() => Function(space))
	)
	{
	}

	private static IEnumerable<Node> Function
	(
		IScalar<Node3D> space
	)
	{
		IEnumerable<INullable<Node>> nullables = new ActualNullablesOfBatch(space);
		foreach (INullable<Node> nullable in nullables)
			if (nullable.Existing.State)
				yield return nullable.Value;
	}
}