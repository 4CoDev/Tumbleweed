using Placement = DotGod.Node.Batch.Entity.Placement;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;
using Action = DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.Specific.Action;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.Specific.Whole;

public sealed class One : Placement::Envelope
{
	public One
	(
		Batch::Any batch,
		Entity::Any entity
	) : base
	(
		new Placement::With.Members.One(
			new Action::Place(batch, entity),
			new Action::Remove(batch, entity))
	)
	{
	}
}