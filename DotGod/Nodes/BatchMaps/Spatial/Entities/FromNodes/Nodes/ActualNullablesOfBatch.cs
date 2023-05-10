using DotGod.Nodes.BatchMaps.Spatial.Entities.Nodes;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Nullables;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities.FromNodes.Nodes;

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