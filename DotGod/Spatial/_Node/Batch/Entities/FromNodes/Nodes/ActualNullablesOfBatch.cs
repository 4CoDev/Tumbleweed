using DotGod.Spatial._Node.Batch.Entities.Nodes;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Nullable;

namespace DotGod.Spatial._Node.Batch.Entities.FromNodes.Nodes;

public sealed class ActualNullablesOfBatch : Tumbleweed.Enumerable.Envelope<Any<Godot.Node>>
{
	public ActualNullablesOfBatch(Tumbleweed.Scalar.Immutable.Any<Node3D> space) : base
	(
		new Selected<ISpatialEntity, Any<Godot.Node>>(
			new EntitiesOfBatch(space),
			entity => new NodeOfEntity(entity))
	)
	{
	}
}