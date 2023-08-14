using Array = Tumbleweed.Array;
using Nullable = Tumbleweed.Scalar.Nullable;
using SCG = System.Collections.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Unmeasured;

public interface Any
{
	Array::Any<Nullable::Any<Any>> Subbatches { get; }
	
	SCG::ICollection<Entity.Any> Entities { get; }
}