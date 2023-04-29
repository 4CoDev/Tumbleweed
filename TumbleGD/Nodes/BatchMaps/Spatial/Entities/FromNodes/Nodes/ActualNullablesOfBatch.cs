using Godot;
using TumbleGD.Nodes.BatchMaps.Spatial.Entities.Nodes;
using Tumbleweed.Enumerables;
using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Entities.FromNodes.Nodes;

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