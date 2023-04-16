using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes.Nodes;

public sealed class ActualOfSpace : EnumerableEnvelope<Node>
{
	public ActualOfSpace(IScalar<Node3D> space) : base
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
		IEnumerable<INullable<Node>> nullables = new ActualNullablesOfSpace(space);
		foreach (INullable<Node> nullable in nullables)
			if (nullable.Existing.State)
				yield return nullable.Value;
	}
}