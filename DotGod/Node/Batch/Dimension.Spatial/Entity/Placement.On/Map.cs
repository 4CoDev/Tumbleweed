using Placement = DotGod.Node.Batch.Entity.Placement;
using SpatialPlacement = DotGod.Node.Batch.Dimension.Spatial.Entity.Placement;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;
using Action = DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.On.Batch.Descendant.Action;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.On;

public sealed class Map : Placement::Envelope
{
	public Map
	(
		Map::Any map,
		Entity::Any entity
	) : base
	(
		new SpatialPlacement::On.Batch.Descendant.Whole.One(
			new Map::Member.Batch.Measured(map),
			entity)
	)
	{
	}
}