using DotGod.Spatial._Node.Batch.Entities.Nodes;
using Godot;
using Tumbleweed.Enumerable;

namespace DotGod.Spatial._Node.Batch.Entities.FromNodes.Nodes;

public sealed class ActualNullablesOfBatch :
	Envelope<Tumbleweed.Nullable.Any<Godot.Node>>
{
	public ActualNullablesOfBatch(Tumbleweed.Scalar.Any<Node3D> space) : base
	(
		new Selected<ISpatialEntity, Tumbleweed.Nullable.Any<Godot.Node>>(
			new EntitiesOfBatch(space),
			entity => new NodeOfEntity(entity))
	)
	{
	}
}