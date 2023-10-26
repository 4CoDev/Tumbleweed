using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;
using Placement = DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.On.Batch;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.On.Batch.Descendant.Action;

public sealed class Place : Procedure::Envelope
{
	public Place
	(
		Batch::Any batch,
		Entity::Any entity
	) : base
	(
		new Placement::Specific.Action.Place(
			new Batch::Bounding.Just.Entity.One(batch, entity),
			entity)
	)
	{
	}
}