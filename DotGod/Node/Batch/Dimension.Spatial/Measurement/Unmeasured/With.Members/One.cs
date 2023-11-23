using Tumbleweed.Array.Dimension.Multi;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using Array = Tumbleweed.Array;
using Option = Tumbleweed.Property.Option;
using SCG = System.Collections.Generic;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.With.Members;

public sealed class One : Batch::Any
{
	public One
	(
		Any<Option::Any<Batch::Any>> subbatches,
		SCG::ICollection<Entity::Any> entities
	)
	{
		Subbatches = subbatches;
		Entities = entities;
	}

	public Any<Option::Any<Batch::Any>> Subbatches { get; }

	public SCG::ICollection<Entity::Any> Entities { get;}
}