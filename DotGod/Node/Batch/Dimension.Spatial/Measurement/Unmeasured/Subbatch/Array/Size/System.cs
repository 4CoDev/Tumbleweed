using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Subbatch.Array.Size;

public sealed class System : Envelope<System::Int32>
{
	public System() : base
	(
		new Uniform
			<System::Int32>
			(2)
	)
	{
	}
}