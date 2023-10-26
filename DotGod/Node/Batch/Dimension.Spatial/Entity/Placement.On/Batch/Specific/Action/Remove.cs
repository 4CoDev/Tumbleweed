using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.On.Batch.Specific.Action;

public sealed class Remove : Procedure::Envelope
{
	public Remove
	(
		Batch::Any batch,
		Entity::Any entity
	) : base
	(
		new Procedure::From.System(
			() => batch.Entities.Remove(entity))
	)
	{
	}
}