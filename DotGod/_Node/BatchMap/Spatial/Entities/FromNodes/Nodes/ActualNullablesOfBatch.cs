using DotGod._Node.BatchMap.Spatial.Entities.Nodes;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace DotGod._Node.BatchMap.Spatial.Entities.FromNodes.Nodes;

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