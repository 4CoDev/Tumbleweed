using Tumbleweed.Array.Dimension.Multi;
using Array = Tumbleweed.Array;
using Option = Tumbleweed.Property.Option;
using SCG = System.Collections.Generic;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;

public interface Any
{
	Any<Option::Any<Any>> Subbatches { get; }
	
	SCG::ICollection<Entity::Any> Entities { get; }
}