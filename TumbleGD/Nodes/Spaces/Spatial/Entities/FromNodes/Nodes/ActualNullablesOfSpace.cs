using Godot;
using TumbleGD.Nodes.Spaces.Spatial.Entities.Nodes;
using Tumbleweed.Enumerables;
using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes.Nodes;

public sealed class ActualNullablesOfSpace :
	EnumerableEnvelope<INullable<Node>>
{
	public ActualNullablesOfSpace(IScalar<Node3D> space) : base
	(
		new SelectedByExpression<ISpatialEntity, INullable<Node>>(
			new EntitiesOfSpace(space),
			entity => new NodeOfEntity(entity))
	)
	{
	}
}