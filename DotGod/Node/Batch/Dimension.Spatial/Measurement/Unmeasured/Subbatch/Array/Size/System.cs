using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Point = Tumbleweed.Point.Spatial;
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