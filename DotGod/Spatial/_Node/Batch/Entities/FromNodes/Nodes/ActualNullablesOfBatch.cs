using DotGod.Spatial._Node.Batch.Entities.Nodes;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch.Entities.FromNodes.Nodes;

public sealed class ActualNullablesOfBatch :
	EnumerableEnvelope<INullable<Node>>
{
	public ActualNullablesOfBatch(IScalar<Node3D> space) : base
	(
		new SelectedByExpression<ISpatialEntity, INullable<Node>>(
			new EntitiesOfBatch(space),
			entity => new NodeOfEntity(entity))
	)
	{
	}
}