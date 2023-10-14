using Tumbleweed.Array.Dimension.Multi;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using Array = Tumbleweed.Array;
using Nullable = Tumbleweed.Scalar.Nullable;
using SCG = System.Collections.Generic;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.With.Members;

public sealed class One : Batch::Any
{
	public One
	(
		Any<Nullable::Any<Batch::Any>> subbatches,
		SCG::ICollection<Entity::Any> entities
	)
	{
		Subbatches = subbatches;
		Entities = entities;
	}

	public Any<Nullable::Any<Batch::Any>> Subbatches { get; }

	public SCG::ICollection<Entity::Any> Entities { get;}
}