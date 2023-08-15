using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Batch = DotGod.Node.Batch.Dimension.Spatial;
using Action = DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.Descendant
	.Action;
using Placement = DotGod.Node.Batch.Entity.Placement;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Placement.Descendant
	.Action.Affect.By.Procedure;

public sealed class One : Procedure::Envelope
{
	public One
	(
		Map::Any map,
		Batch::Entity.Any entity,
		Procedure::Any procedure
	) : this
	(
		new Map::Member.Batch.Measured(map),
		entity,
		procedure
	)
	{
	}
	
	public One
	(
		Batch::Measurement.Measured.Any batch,
		Batch::Entity.Any entity,
		Procedure::Any procedure
	) : base
	(
		new Procedure::Of.Procedures(
			new Action::Remove(batch, entity),
			procedure,
			new Action::Place(batch, entity))
	)
	{
	}

	public One
	(
		Placement::Any placement,
		Procedure::Any procedure
	) : base
	(
		new Procedure::Of.Procedures(
			new Placement::Member.Remove(placement),
			procedure,
			new Placement::Member.Place(placement))
	)
	{
	}
}