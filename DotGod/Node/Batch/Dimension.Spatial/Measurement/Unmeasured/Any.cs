using Tumbleweed.Array.Dimension.Multi;
using Array = Tumbleweed.Array;
using Nullable = Tumbleweed.Scalar.Nullable;
using SCG = System.Collections.Generic;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;

public interface Any
{
	Any<Nullable::Any<Any>> Subbatches { get; }
	
	SCG::ICollection<Entity::Any> Entities { get; }
}