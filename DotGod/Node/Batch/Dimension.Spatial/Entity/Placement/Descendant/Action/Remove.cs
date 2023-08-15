using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;
using Specific = DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.Specific;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.Descendant.Action;

public sealed class Remove : Procedure::Envelope
{
	public Remove
	(
		Batch::Any batch,
		Entity::Any entity
	) : base
	(
		new Specific::Action.Remove(
			new Batch::Bounding.Just.Entity.One(batch, entity),
			entity)
	)
	{
	}
}